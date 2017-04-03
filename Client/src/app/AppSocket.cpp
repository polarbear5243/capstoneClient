/*
 * Socket.h
 *
 *  Created on: Mar 28, 2017
 *      Author: YJK
 */
#include <app/AppSocket.h>

AppSocket::AppSocket(){
	fd_set sock;
	sockaddr_in server;
	server.sin_addr.s_addr = inet_addr("192.168.0.15");

	server.sin_family = AF_INET;
	server.sin_port = htons(SERVER_PORT);

    struct timeval timeout;
    timeout.tv_sec = 2;
    timeout.tv_usec = 0;

    int opt = 3;

	mSocket = socket(AF_INET, SOCK_STREAM,0);

	setsockopt(mSocket, SOL_SOCKET, SO_RCVLOWAT,&opt,sizeof(opt));

	FD_ZERO(&sock);
	FD_SET(mSocket,&sock);

	if(select(mSocket+1,&sock,NULL,NULL,&timeout) <= 0)
		throw exception();

/*    if (setsockopt (mSocket, SOL_SOCKET, SO_RCVTIMEO, (char *)&timeout, sizeof(timeout)) < 0)
        throw exception();*/

/*	if(mSocket < 0) {
		throw exception();
	}*/
	if(connect(mSocket,(sockaddr *)&server, sizeof(server)) < 0){
		throw exception();
	}
}
void AppSocket::sendData(string str){
	if(send(mSocket,str.c_str(),str.length(), 0) < 0)
		throw exception();
}
string AppSocket::receiveData(){

	char * buf = new char[BUF_SIZE];

	if(recv(mSocket,buf,BUF_SIZE,0) < 0)
	{
		throw exception();
	}

	string result(buf);
	delete buf;

	return result;
}
