/*
 * MyMainScroll.h
 *
 *  Created on: Apr 1, 2017
 *      Author: BGKG
 */

#pragma once
#include"gui/layout/Box.h"
#include"gui/layout/Conformant.h"
#include"gui/layout/Naviframe.h"
#include"gui/layout/NaviItem.h"
#include"gui/layout/Layout.h"
#include"gui/layout/Scroll.h"
#include"gui/layout/BackGround.h"

#include <app/mainView/food/foodMain/FoodMainView.h>
#include <app/mainView/recipe/RecipeMain/RecipeMainView.h>

#include<string>

class MainViewl
{
	class FoodBtn : public Button
	{
	private:
		Naviframe* mNaviframe;
	public:
		FoodBtn(UILayout parent, Naviframe * naviframe) : Button(parent) {
			mNaviframe = naviframe;
			this->setText("식재료");
			setMinHint(0, 150);
			setMaxHint(600, 9999);
		}
		void click()
		{
			new FoodMainView(mNaviframe);
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
			RecipeMainView* m = new RecipeMainView(mNaviframe);
		}
	};
	class LogBtn : public Button
	{
	private:
		Naviframe* mNaviframe;
	public:
		LogBtn(UILayout parent, Naviframe * naviframe) : Button(parent) {
			mNaviframe = naviframe;
			this->setText("로그");
			setMinHint(0, 150);
			setMaxHint(600, 9999);
		}
		void click()
		{

		}
	};
	class LogoutBtn : public Button
	{
	private:
		Naviframe* mNaviframe;
	public:
		LogoutBtn(UILayout parent, Naviframe * naviframe) : Button(parent) {
			mNaviframe = naviframe;
			this->setText("로그아웃");
			setMinHint(0, 150);
			setMaxHint(600, 9999);
		}
		void click()
		{

		}
	};
private:
	Background* mBg;
	Scroll* mScroll;
	Layout* mLayout;
	Box* mBox;
	FoodBtn* mBtnFood;
	RecipeBtn* mBtnRecipe;
	LogBtn* mBtnLog;
	LogoutBtn* mBtnLogout;

public:
	MainViewl(Naviframe * parentNavi){
		drawUI(parentNavi);
	}
protected:
	void drawUI(Naviframe* parentNavi)
	{
		mBg = new Background(*parentNavi);
		mBg->setColor(255,255,255);

		Button nullBtn;
		parentNavi->addItem("메인",nullBtn,nullBtn,*mBg,"").setTitleEnalble(TRUE, TRUE);

		mScroll = new Scroll(*mBg);
		elm_object_content_set(mBg->getContent(),mScroll->getContent());

		mLayout = new Layout(*mScroll);
		mLayout->setTheme("layout", "application", "default");
		mLayout->setWeightHint(EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
		mLayout->setAlignHint(EVAS_HINT_FILL, EVAS_HINT_EXPAND);
		mScroll->add(*mLayout);

		mBox = new Box(*mLayout);
		//mBox->setPadding(0, ELM_SCALE_SIZE(10));
		mBox->setPadding(0,10);
		mLayout->setContent("elm.swallow.content", *mBox);

		mBtnFood = new FoodBtn(*mBox, parentNavi);
		mBox->addBack(*mBtnFood);

		mBtnRecipe = new RecipeBtn(*mBox, parentNavi);
		mBox->addBack(*mBtnRecipe);

		mBtnLog = new LogBtn(*mBox, parentNavi);
		mBox->addBack(*mBtnLog);

		mBtnLogout = new LogoutBtn(*mBox, parentNavi);
		mBox->addBack(*mBtnLogout);
	}
};
