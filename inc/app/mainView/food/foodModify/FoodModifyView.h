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

#include"FoodModifyBackButton.h"
#include"FoodModifyDeleteButton.h"
#include"FoodModifyFavoritesButton.h"

#include"app/mainView/food/foodMain/BreakCycle.h"

class FoodModifyView{
private:
	string mFoodName;
	string mFoodId;
	BreakCycle * mMainList;
	void * mTargetItem;

	Background * mBackground;
	Layout * mLayout;
	Scroll * mScroller;

	Entry * mFoodInfo;
	FoodModifyBackButton * mBackBtn;
	FoodModifyDeleteButton * mDeleteBtn;

	NaviItem mNaviItem;
public:
	FoodModifyView(Naviframe* parent,string foodName, string foodId, BreakCycle * mainList, void * targetItem){

		mFoodId = foodId;
		mFoodName = foodName;
		mMainList = mainList;
		mTargetItem = targetItem;

		mNaviItem = NaviItem();

		drawUI(parent);
	}
	void drawUI(Naviframe* parent){
		mBackground = new Background(*parent);
		mBackground->setColor(255,255,255);

		Button nullBtn;
		mNaviItem = parent->addItem("식재료-수정",nullBtn,nullBtn,*mBackground,"");
		mNaviItem.setTitleEnalble(TRUE, TRUE);

		mScroller = new Scroll(*mBackground);
		mBackground->add(*mScroller);

		mLayout = new Layout(*mScroller);
		mLayout->setEDCfile("food_modify_layout");
		mScroller->add(*mLayout);

		mFoodInfo = new Entry(*mLayout);
		mFoodInfo->setScrollable();
		mFoodInfo->setMultLine();

		string note = "이름 : " + mFoodName + "\r"
					+ "Food ID : " + mFoodId;
		mFoodInfo->setText(note);

		mLayout->setContent("elm.swallow.foodInfoEntry",*mFoodInfo);

		mBackBtn = new FoodModifyBackButton(*mLayout, parent);
		mLayout->setContent("elm.swallow.backButtons",*mBackBtn);

		mDeleteBtn = new FoodModifyDeleteButton(*mLayout,mMainList,mTargetItem,parent,mFoodName,mFoodId);
		mLayout->setContent("elm.swallow.addButtons",*mDeleteBtn);
	}
};
