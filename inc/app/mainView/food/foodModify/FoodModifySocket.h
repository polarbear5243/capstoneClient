#pragma once
#include"app/AppSocket.h"
#include"app/AppParser.h"

#include"app/DataModel/Groceries.h"

#include<string>

using namespace std;

class FoodModifySocket{
protected:
	AppSocket * mSocket;
public:
	FoodModifySocket(){
		mSocket = new AppSocket();
	}

	bool deleteUserIngredient(string userId, string ingredientName){
		vector<string> msg;
		msg.push_back("Ingredient");
		msg.push_back("Delete");
		msg.push_back(userId);
		msg.push_back(ingredientName);

		mSocket->sendData(AppParser::wrapMsg(msg));
		msg = AppParser::parsingMsg(mSocket->receiveData());

		if(msg.at(0).compare("Success") == 0)
			return true;
		else
			return false;
	}
};
