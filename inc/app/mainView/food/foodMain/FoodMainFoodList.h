#pragma once

#include"gui/layout/Naviframe.h"
#include"gui/object/List.h"
#include"app/DataModel/UserInfo.h"
#include"app/DataModel/Groceries.h"

#include"FoodMainFoodItem.h"
#include"BreakCycle.h"
#include<list>
#include<string>

using namespace std;

class FoodMainFoodList : public List, BreakCycle {
private:
	list<FoodMainFoodItem *> mListItem;
	Naviframe * mParentNavi;
public:
	FoodMainFoodList(UILayout parent, Naviframe * parentNavi) : List(parent) {
		mListItem = list<FoodMainFoodItem * >();
		mParentNavi = parentNavi;

		UserInfo * myInfo = UserInfo::getInstance();
		list<Groceries * > * myGroceries = myInfo->getMyGroceries();

		FoodMainFoodItem * tmp = NULL;

		for(list<Groceries * >::iterator it = myGroceries->begin();it != myGroceries->end();it++){
			tmp = new FoodMainFoodItem((*it)->mName,(*it)->mID, parentNavi);
			mListItem.push_back(tmp);
		}
		refresh();
	}
	void search(string str){
		this->clear();

		Popup* toast = new Popup();
		toast->setStyle("toast");
		elm_object_text_set(toast->getContent(), str.c_str());
		toast->setTimeout(2.0);

		if(str.compare("") == 0){
			refresh();
			return;
		}

		list<FoodMainFoodItem * >::iterator it;
		for(it=mListItem.begin();it!=mListItem.end();it++){
			if(strstr((*it)->mName.c_str(),str.c_str()) != NULL)
				this->addItem(*it);
		}
	}
	void deleteFoodItem(void * itemPointer){
		FoodMainFoodItem * item = (FoodMainFoodItem *)itemPointer;

		list<FoodMainFoodItem * >::iterator it;

		for(it = mListItem.begin();it!=mListItem.end();it++){
			if( (*it) == item ){
				mListItem.erase(it);
				delete item;
				break;
			}
		}
		refresh();
	}
	void addFoodItem(string foodId, string foodName){
		FoodMainFoodItem * tmp = new FoodMainFoodItem(foodName,foodId,mParentNavi);
		mListItem.push_back(tmp);
		this->addItem(tmp);
		refresh();
	}
	void refresh(){
		this->clear();
		for(list<FoodMainFoodItem * >::iterator it = mListItem.begin();it != mListItem.end(); it++)
			this->addItem((*it));
	}
	~FoodMainFoodList(){
		for(list<FoodMainFoodItem * >::iterator it = mListItem.begin();it != mListItem.end(); it++)
			delete *it;
		mListItem.clear();
	}
};
