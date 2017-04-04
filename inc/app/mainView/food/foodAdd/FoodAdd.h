#pragma once
#include"gui/layout/Box.h"
#include"gui/layout/Naviframe.h"
#include"gui/object/Entry.h"
#include"gui/layout/Layout.h"
#include"gui/layout/BackGround.h"
#include"gui/object/popup.h"
#include"gui/layout/Scroll.h"
#include"gui/object/List.h"

#include"BackButton.h"
#include"SearchButton.h"

using namespace FoodMain;

class FoodAdd
{
private:
	Background * mBackground;
	Layout * mLayout;
	Scroll * mScroller;

	Entry * mSearchEntrty;
	SearchButton * mSearchBtn;

	List * mfoodList;

	BackButton * mBackBtn;

	NaviItem mNaviItem;
public:
	FoodAdd(Naviframe* parent){
		mNaviItem = NaviItem();

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

		mSearchBtn = new SearchButton(*mLayout);
		mLayout->setContent("elm.swallow.searchBtn",*mSearchBtn);

		mfoodList = new List(*mLayout);
		mLayout->setContent("elm.swallow.foodList",*mfoodList);

		mBackBtn = new BackButton(*mLayout);
		mLayout->setContent("elm.swallow.backButtons",*mBackBtn);
	}
};
