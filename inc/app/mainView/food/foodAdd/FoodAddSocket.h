#pragma once
#include"app/AppSocket.h"
#include"app/AppParser.h"

#include"app/DataModel/Groceries.h"

#include<string>

using namespace std;

class FoodAddSocket{
protected:
	AppSocket * mSocket;
public:
	FoodAddSocket(){
		mSocket = new AppSocket();
	}
	vector<Groceries> getAllIngredient(){
		vector<string> msg;
		msg.push_back("Ingredient");
		msg.push_back("GetAll");

		mSocket->sendData(AppParser::wrapMsg(msg));
		msg = AppParser::parsingMsg(mSocket->receiveData());

		vector<Groceries> result;
		int i=1;
		string id;
		string name;
		while(true){
			id = msg.at(i);
			if(id.compare("End") == 0)
				break;
			name = msg.at(i+1);
			result.push_back(Groceries(id,name));
			i+=2;
		}
		return result;
	}
	bool addMyIngredient(string userId, string ingredientId, string ingredientName){
		vector<string> msg;
		msg.push_back("Ingredient");
		msg.push_back("Add");
		msg.push_back(userId);
		msg.push_back(ingredientId);
		msg.push_back(ingredientName);

		mSocket->sendData(AppParser::wrapMsg(msg));
		msg = AppParser::parsingMsg(mSocket->receiveData());

		if(msg.at(0).compare("Success") == 0)
			return true;
		else
			return false;
	}
};
