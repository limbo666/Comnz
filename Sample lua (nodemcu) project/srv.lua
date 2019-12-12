--udpPort=55155
udpSocket = net.createUDPSocket()
udpSocket:listen(udpPort)
udpSocket:on("receive", function(s, data, port, ip)
 --	print(data)
	if data~=nil then
		print('data:'..data)
		Rspnd=string.find(data,"Comnz")
		if Rspnd~=nil then
			Rspnd=(string.sub(data,string.find(data,"Comnz") +7,string.find(data,"Comnz")+10))	
		--	print(Rspnd)
			if Rspnd == "1" then
			--	print("received one")
				confirm("1")
			elseif Rspnd == "2" then
			--	print("received two")
				confirm("2")
			elseif Rspnd == "3" then
			--	print("received three")
			end 
		end
	end 
end)
port, ip = udpSocket:getaddr()
print("started UDP server on port "..udpPort)