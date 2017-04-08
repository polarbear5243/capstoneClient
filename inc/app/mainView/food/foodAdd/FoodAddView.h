#pragma once
#include <app/mainView/food/foodAdd/FoodAddBackButton.h>
#include <app/mainView/food/foodAdd/FoodAddFoodList.h>
#include <app/mainView/food/foodAdd/FoodAddSearchButton.h>
#include <app/mainView/food/foodMain/FoodMainFoodList.h>
#include"gui/layout/Box.h"
#include"gui/layout/Naviframe.h"
#include"gui/object/Entry.h"
#include"gui/layout/Layout.h"
#include"gui/layout/BackGround.h"
#include"gui/object/popup.h"
#include"gui/layout/Scroll.h"
#include"gui/object/List.h"

#include"FoodAddSocket.h"

#include<vector>
#include"app/DataModel/Groceries.h"


using namespace std;

class FoodAddView
{
private:
	vector<Groceries> mList;
	FoodMainFoodList * mParentList;

	Background * mBackground;
	Layout * mLayout;
	Scroll * mScroller;

	Entry * mSearchEntrty;
	FoodAddSearchButton * mSearchBtn;

	FoodAddFoodList * mfoodList;

	FoodAddBackButton * mBackBtn;

	NaviItem mNaviItem;

public:
	FoodAddView(Naviframe* parent, FoodMainFoodList * foodList){
		mNaviItem = NaviItem();
		mfoodList = NULL;
		mSearchEntrty = NULL;
		mParentList = foodList;

		FoodAddSocket * socket = new FoodAddSocket();
		mList = socket->getAllIngredient();
		delete socket;

		drawUI(parent);
	}
	void drawUI(Naviframe* parent){
		mBackground = new Background(*parent);
		mBackground->setColor(255,255,255);

		Button nullBtn;
		mNaviItem = parent->addItem("식재료-추가",nullBtn,nullBtn,*mBackground,"");
		mNaviItem.setTitleEnalble(TRUE, TRUE);

		mScroller = new Scroll(*mBackground);
		mBackground->add(*mScroller);

		mLayout = new Layout(*mScroller);
		mLayout->setEDCfile("food_add_layout");
		mScroller->add(*mLayout);

		mSearchEntrty = new Entry(*mLayout);
		mSearchEntrty->setSingleLine();
		mSearchEntrty->setScrollable();
		mLayout->setContent("elm.swallow.searchEntry",*mSearchEntrty);

		mfoodList = new FoodAddFoodList(*mLayout, &mList, mParentList);
		mLayout->setContent("elm.swallow.foodList",*mfoodList);

		mSearchBtn = new FoodAddSearchButton(*mLayout, mSearchEntrty, mfoodList);
		mLayout->setContent("elm.swallow.searchBtn",*mSearchBtn);

		mBackBtn = new FoodAddBackButton(*mLayout, parent);
		mLayout->setContent("elm.swallow.backButtons",*mBackBtn);
	}
};
