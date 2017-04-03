/*
 * Socket.h
 *
 *  Created on: Mar 28, 2017
 *      Author: YJK
 */
#pragma once
#include<string>
#include <arpa/inet.h>
#include <glib.h>
#include <net/if.h>
#include <sys/stat.h>

using namespace std;

class AppSocket{

private:
	static const int BUF_SIZE = 1024;
	static const int SERVER_PORT = 26100;
protected:
	int mSocket;

public:
	AppSocket();
	void sendData(string str);
	string receiveData();
};
