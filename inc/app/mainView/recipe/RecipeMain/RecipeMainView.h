/*
 * MyRecipeView.h
 *
 *  Created on: Apr 1, 2017
 *      Author: BGKG
 */

#pragma once
#include"gui/layout/Box.h"
#include"gui/layout/Conformant.h"
#include"gui/layout/Naviframe.h"
#include"gui/layout/Layout.h"
#include"gui/layout/BackGround.h"
#include"gui/layout/Scroll.h"
#include"app/mainView/recipe/RecipeList/RecipeListView.h"

class RecommendBtn : public Button
{
private:
	Naviframe* mNaviframe;
public:
	RecommendBtn(UILayout parent, Naviframe * naviframe) : Button(parent) {
		mNaviframe = naviframe;
		this->setText("추천");
		setMinHint(0, 150);
		setMaxHint(600, 9999);
	}
	void click()
	{

	}
};
class RecipeBtn : public Button
{
private:
	Naviframe* mNaviframe;
public:
	RecipeBtn(UILayout parent, Naviframe * naviframe) : Button(parent) {
		mNaviframe = naviframe;
		this->setText("레시피");
		setMinHint(0, 150);
		setMaxHint(600, 9999);
	}
	void click()
	{
		RecipeListView* s = new RecipeListView(mNaviframe);
	}
};
class BackBtn : public Button
{
private:
	Naviframe* mNaviframe;
public:
	BackBtn(UILayout parent, Naviframe * naviframe) : Button(parent) {
		mNaviframe = naviframe;
		this->setText("뒤로가기");
		setMinHint(0, 150);
		setMaxHint(600, 9999);
	}
	void click()
	{
		mNaviframe->popItem();
	}
};

class RecipeMainView
{
private:
	Background* mBg;
	Scroll* mScroll;
	Layout* mLayout;
	Box* mBox;

	RecommendBtn* mBtnRecommend;
	RecipeBtn* mBtnRecipe;
	BackBtn* mBtnBack;
public:
	RecipeMainView(Naviframe* parentNavi){
		drawUI(parentNavi);
	}
	void drawUI(Naviframe* parentNavi){
		mBg = new Background(*parentNavi);
		mBg->setColor(255,255,255);

		Button nullBtn;
		parentNavi->addItem("레시피",nullBtn,nullBtn,*mBg,"").setTitleEnalble(TRUE, TRUE);

		mScroll = new Scroll(*mBg);
		elm_object_content_set(mBg->getContent(),mScroll->getContent());

		mLayout = new Layout(*mScroll);
		mLayout->setTheme("layout", "application", "default");
		mLayout->setWeightHint(EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
		mLayout->setAlignHint(EVAS_HINT_FILL, EVAS_HINT_EXPAND);
		mScroll->add(*mLayout);

		mBox = new Box(*mLayout);
		mBox->setPadding(0,10);
		mLayout->setContent("elm.swallow.content", *mBox);

		mBtnRecommend = new RecommendBtn(*mBox, parentNavi);
		mBox->addBack(*mBtnRecommend);

		mBtnRecipe = new RecipeBtn(*mBox, parentNavi);
		mBox->addBack(*mBtnRecipe);

		mBtnBack = new BackBtn(*mBox, parentNavi);
		mBox->addBack(*mBtnBack);
	}
};
