print("Starting")
wifi.setmode(wifi.STATION) 
wifi.sta.autoconnect(1)
station_cfg={} 
station_cfg.ssid="IWillSniffYourPackets" 
station_cfg.pwd="logmein3" 
station_cfg.save=true 
wifi.sta.config(station_cfg) 
wifi.sta.connect()

gpio.mode(5, gpio.OUTPUT)
gpio.mode(6, gpio.OUTPUT)
gpio.write(5,1)
gpio.write(6,1)

udpPort=55155

print("Waiting for IP address")
IPtmr = tmr.create()
IPtmr:register(100, tmr.ALARM_AUTO, function (t)
	print(".")
	MyIP=wifi.sta.getip()
	if MyIP~= nil then
		print("My IP is: "..MyIP)
		BroadcastAddr= wifi.sta.getbroadcast()
		IPtmr:stop()
		gpio.write(5,0)
		gpio.write(6,0)
		dofile('srv.lua') -- run the UDP server
	end 
end) 
IPtmr:start()

F_ID="AA111" --this is Comnz ID
function actionCall(program,remote_Id,actionType) --this function sends UDP to call program
	if MyIP ~= nil then
		udpSocket = net.createUDPSocket()
		if actionType=="k" then -- reserved for future use
			udpSocket:send(udpPort, BroadcastAddr, "$$exe"..remote_Id.."keys"..keyz.."::"..MyIP )
			keyz=100 -- keyz to high to avoid multiple execution
		end
	end 
end 


keyz=0 -- here we reset the variable
ANAtmr = tmr.create()
ANAtmr:register(100, tmr.ALARM_AUTO, function (t)
	val=  adc.read(0)
	if val <30 then
		keyz=0 -- reset the variable to 0 when the button is released 
		gpio.write(5,0)
		gpio.write(6,0)
	end
	if keyz==0  then
		--print(val)
		if val <930 and val>890 then
			-- button 1
			print("Button 1")
			keyz=1
			gpio.write(5,1)
		elseif val <890 and val>820 then
			-- button 2
			print("Button 2")
			keyz=2
			gpio.write(6,1)
		end 
		if keyz > 0 and keyz <100 then
			actionCall(keyz,F_ID,"k")
		end
	end
 
end)
ANAtmr:start()

rounds=0
function confirm(output)
ConfTmr = tmr.create()
ConfTmr:register(20, tmr.ALARM_AUTO, function (t)
	--tmr.alarm(2, 50, 1, function() 
		if rounds <20 then
			rounds= rounds+1
			if (rounds% 2 == 0) then
				if output=="1" then
					gpio.write(5,1)
					--ws2812.write(string.char(0, 0, 200)) 
				elseif output=="2" then
					--ws2812.write(string.char(100, 100, 100)) 
					gpio.write(6,1)
				end
			else
		gpio.write(5,0)
		gpio.write(6,0)
				--ws2812.write(string.char(0, 0, 0)) 
			end 
		else
		gpio.write(5,0)
		gpio.write(6,0)
		--	ws2812.write(string.char(0, 0, 0)) 
			rounds= 0
			ConfTmr:stop()				
		end 	
	end)
ConfTmr:start()
end 




