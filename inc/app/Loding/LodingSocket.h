#include"app/AppSocket.h"
#include"app/AppParser.h"
#include<string>

using namespace std;

class LodingSocket{
protected:
	AppSocket * mSocket;
public:
	LodingSocket(){
		mSocket = new AppSocket();
	}
	vector<string> getMyIngredient(string id){
		vector<string> msg;
		msg.push_back("Ingredient");
		msg.push_back("GetMy");
		msg.push_back(id);

		mSocket->sendData(AppParser::wrapMsg(msg));
		msg = AppParser::parsingMsg(mSocket->receiveData());

		return msg;
	}
	bool userFirstVisit(string userid){
		vector<string> msg;
		msg.push_back("Survey");
		msg.push_back("FirstVisit");
		msg.push_back(userid);

		mSocket->sendData(AppParser::wrapMsg(msg));
		msg = AppParser::parsingMsg(mSocket->receiveData());

		if(msg[0].compare("True")==0)
			return true;

		return false;
	}
	~LodingSocket(){
		delete mSocket;
	}

};
