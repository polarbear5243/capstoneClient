#pragma once
#include <app/mainView/food/foodAdd/FoodAddFoodItem.h>
#include <app/mainView/food/foodMain/FoodMainFoodList.h>
#include"gui/object/List.h"
#include"app/DataModel/Groceries.h"
#include<vector>
#include<string>

using namespace std;

class FoodAddFoodList: public List{
private:
	vector<FoodAddFoodItem *> mListItem;
	FoodMainFoodList * mParentList;

public:
	FoodAddFoodList(UILayout parent,vector<Groceries> * list,FoodMainFoodList * parentList ):List(parent){
		mListItem = vector<FoodAddFoodItem *>();
		mParentList = parentList;
		FoodAddFoodItem * tmp;

		for(int i=0;i<list->size();i++){
			tmp = new FoodAddFoodItem(&(list->at(i)), mParentList);
			this->addItem(tmp);
			mListItem.push_back(tmp);
		}
	}
	void search(string str){
		this->clear();

		Popup* toast = new Popup();
		toast->setStyle("toast");
		elm_object_text_set(toast->getContent(), str.c_str());
		toast->setTimeout(2.0);

		if(str.compare("") == 0){
			for(int i=0;i<mListItem.size();i++)
				this->addItem(mListItem.at(i));
			return;
		}

		for(int i=0;i<mListItem.size();i++){
			if(strstr(mListItem.at(i)->mName.c_str(),str.c_str()) != NULL)
				this->addItem(mListItem.at(i));
		}
	}
	~FoodAddFoodList(){
		for(int i=0;i<mListItem.size();i++){
			delete mListItem.at(i);
		}
		mListItem.clear();
	}
};
