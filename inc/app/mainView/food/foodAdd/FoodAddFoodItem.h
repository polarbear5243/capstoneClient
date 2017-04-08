#pragma once
#include <app/mainView/food/foodMain/FoodMainFoodList.h>
#include"gui/object/ListItem.h"
#include"app/DataModel/Groceries.h"
#include"app/DataModel/UserInfo.h"
#include"FoodAddSocket.h"

#include<vector>
#include<string>

using namespace std;

class FoodAddFoodItem: public ListItem{
private:
	string mName;
	string mId;
	FoodMainFoodList * mParentList;

public:
	FoodAddFoodItem(Groceries * food, FoodMainFoodList * parentList):ListItem(food->mName){
		mName = food->mName;
		mId = food->mID;
		mParentList = parentList;
	}
	void selected(){
		UserInfo * myInfo = UserInfo::getInstance();
		string id = myInfo->getMyId();

		if(myInfo->isExist(mName)){
			Popup* toast = new Popup();
			toast->setStyle("toast");
			elm_object_text_set(toast->getContent(), "이미 있습니다.");
			toast->setTimeout(2.0);
			return;
		}

		FoodAddSocket * socket = new FoodAddSocket();
		bool result = socket->addMyIngredient(id,mId,mName);
		string msg="";

		if(result == true){
			myInfo->addGroceries(mId,mName);
			mParentList->addFoodItem(mId,mName);
			msg = mName + "추가 완료";
		}else{
			msg = "추가 실패";
		}

		Popup* toast = new Popup();
		toast->setStyle("toast");
		elm_object_text_set(toast->getContent(), msg.c_str());
		toast->setTimeout(2.0);
	}
	friend class FoodAddFoodList;
};
