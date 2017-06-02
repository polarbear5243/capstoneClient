#pragma once
#include"app/AppSocket.h"
#include"app/AppParser.h"

#include<iostream>
#include<string>
#include<sstream>

using namespace std;

class RecommendSocket{
protected:
	AppSocket * mSocket;
public:
	RecommendSocket(){
		mSocket = new AppSocket();
	}
	vector<string> getRecommendRecipe(string userid, int like[4]){
		vector<string> msg;
		msg.push_back("Recipe");
		msg.push_back("Recommend");
		msg.push_back(userid);
		for(int i=0;i<4;i++) {
			ostringstream s;
			s << like[i];
			msg.push_back(s.str());
		}

		mSocket->sendData(AppParser::wrapMsg(msg));
		msg = AppParser::parsingMsg(mSocket->receiveData());

		return msg;
	}
	~RecommendSocket(){
		delete mSocket;
	}
};
