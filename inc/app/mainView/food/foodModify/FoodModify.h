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



using namespace FM;

class FoodModify{
private:
	Background * mBackground;
	Layout * mLayout;
	Scroll * mScroller;

	Entry * mFoodInfo;
	FavoritesButton * mFavoritesBtn;
	BackButton * mBackBtn;
	DeleteButton * mDeleteBtn;

	NaviItem mNaviItem;
public:
	FoodModify(Naviframe* parent){
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
		mLayout->setContent("elm.swallow.foodInfoEntry",*mFoodInfo);

		mFavoritesBtn = new FavoritesButton(*mLayout);
		mLayout->setContent("elm.swallow.favoritesButton",*mFavoritesBtn);

		mBackBtn = new BackButton(*mLayout);
		mLayout->setContent("elm.swallow.backButtons",*mBackBtn);

		mDeleteBtn = new DeleteButton(*mLayout);
		mLayout->setContent("elm.swallow.addButtons"),*mDeleteBtn);
	}
};
