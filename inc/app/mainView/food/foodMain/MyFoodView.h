/*
 * MyRecipeView.h
 *
 *  Created on: Apr 1, 2017
 *      Author: BGKG
 */

#pragma once
#include"gui/layout/Box.h"
#include"gui/layout/Naviframe.h"
#include"gui/object/Entry.h"
#include"gui/layout/Layout.h"
#include"gui/layout/BackGround.h"
#include"gui/object/popup.h"
#include"gui/layout/Scroll.h"
#include"gui/object/List.h"

#include"SearchButton.h"
#include"BackButton.h"
#include"AddButton.h"

using namespace FoodMain;

class MyFoodView
{
private:
	Background * mBackground;
	Layout * mLayout;
	Scroll * mScroller;

	Entry * mSearchEntrty;
	SearchButton * mSearchBtn;

	List * mfoodList;

	BackButton * mBackBtn;
	AddButton * mAddBtn;

	NaviItem mNaviItem;
public:
	MyFoodView(Naviframe* parent){
		mNaviItem = NaviItem();

		drawUI(parent);
	}
	void drawUI(Naviframe* parent){
		mBackground = new Background(*parent);
		mBackground->setColor(255,255,255);

		Button nullBtn;
		mNaviItem = parent->addItem("식재료-보유",nullBtn,nullBtn,*mBackground,"");
		mNaviItem.setTitleEnalble(TRUE, TRUE);

		mScroller = new Scroll(*mBackground);
		mBackground->add(*mScroller);

		mLayout = new Layout(*mScroller);
		mLayout->setEDCfile("food_layout");
		mScroller->add(*mLayout);

		mSearchEntrty = new Entry(*mLayout);
		mSearchEntrty->setSingleLine();
		mSearchEntrty->setScrollable();
		mLayout->setContent("elm.swallow.searchEntry",*mSearchEntrty);

		mSearchBtn = new SearchButton(*mLayout);
		mSearchBtn->setWeightHint(EVAS_HINT_EXPAND,EVAS_HINT_EXPAND);
		mLayout->setContent("elm.swallow.searchBtn",*mSearchBtn);

		mfoodList = new List(*mLayout);
		mfoodList->setWeightHint(EVAS_HINT_EXPAND,EVAS_HINT_EXPAND);
		mLayout->setContent("elm.swallow.foodList",*mfoodList);

		mBackBtn = new BackButton(*mLayout);
		mBackBtn->setWeightHint(EVAS_HINT_EXPAND,EVAS_HINT_EXPAND);
		mLayout->setContent("elm.swallow.backButtons",*mBackBtn);

		mAddBtn = new AddButton(*mLayout,parent);
		mAddBtn->setText("추가");
		mBackBtn->setWeightHint(EVAS_HINT_EXPAND,EVAS_HINT_EXPAND);
		mLayout->setContent("elm.swallow.addButtons",*mAddBtn);

	}
};
