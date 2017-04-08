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

	~LodingSocket(){
		delete mSocket;
	}

};
