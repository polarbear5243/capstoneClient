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

#include "FoodMainAddButton.h"
#include "FoodMainBackButton.h"
#include "FoodMainSearchButton.h"
#include "FoodMainView.h"
#include "FoodMainFoodList.h"

class FoodMainView
{
private:
	static FoodMainView * mInstance;
public:
	static FoodMainView * getInstance(){
		return mInstance;
	}
private:
	Background * mBackground;
	Layout * mLayout;
	Scroll * mScroller;

	Entry * mSearchEntrty;
	FoodMainSearchButton * mSearchBtn;

	FoodMainFoodList * mfoodList;

	FoodMainBackButton * mBackBtn;
	FoodMainAddButton * mAddBtn;

	NaviItem mNaviItem;
public:
	FoodMainView(Naviframe* parent){
		mInstance = this;

		mNaviItem = NaviItem();
		mSearchEntrty = NULL;
		mfoodList = NULL;

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

		mfoodList = new FoodMainFoodList(*mLayout, parent);
		mfoodList->setWeightHint(EVAS_HINT_EXPAND,EVAS_HINT_EXPAND);
		mLayout->setContent("elm.swallow.foodList",*mfoodList);

		mBackBtn = new FoodMainBackButton(*mLayout);
		mBackBtn->setWeightHint(EVAS_HINT_EXPAND,EVAS_HINT_EXPAND);
		mLayout->setContent("elm.swallow.backButtons",*mBackBtn);

		mSearchBtn = new FoodMainSearchButton(*mLayout,mSearchEntrty, mfoodList);
		mSearchBtn->setWeightHint(EVAS_HINT_EXPAND,EVAS_HINT_EXPAND);
		mLayout->setContent("elm.swallow.searchBtn",*mSearchBtn);

		mAddBtn = new FoodMainAddButton(*mLayout,parent, mfoodList);
		mAddBtn->setText("추가");
		mBackBtn->setWeightHint(EVAS_HINT_EXPAND,EVAS_HINT_EXPAND);
		mLayout->setContent("elm.swallow.addButtons",*mAddBtn);

	}
};
FoodMainView * FoodMainView::mInstance = NULL;
