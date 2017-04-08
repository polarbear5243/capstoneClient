#pragma once
#include <app/mainView/food/foodModify/FoodModifyView.h>
#include"gui/object/ListItem.h"
#include"gui/layout/Naviframe.h"
#include<string>

#include"BreakCycle.h"

using namespace std;

class FoodMainFoodItem: public ListItem{
private:
	string mName;
	string mId;
	Naviframe * mParentNavi;

public:
	FoodMainFoodItem(string name, string id, Naviframe * parentNavi):ListItem(name){
		mName = name;
		mId = id;
		mParentNavi = parentNavi;
	}
	void selected(){
		BreakCycle * mainList = BreakCycle::getInstance();
		new FoodModifyView(mParentNavi,mName,mId,mainList,this);
	}
	friend class FoodMainFoodList;
};
