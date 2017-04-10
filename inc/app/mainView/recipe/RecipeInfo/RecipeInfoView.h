/*
 * MyRecipeInfo.h
 *
 *  Created on: Apr 5, 2017
 *      Author: BGKG
 */

#pragma once
#include"gui/object/Label.h"
#include"gui/layout/Box.h"
#include"gui/layout/Conformant.h"
#include"gui/layout/Naviframe.h"
#include"gui/object/Entry.h"
#include"gui/layout/Layout.h"
#include"gui/layout/BackGround.h"
#include"gui/object/popup.h"
#include"gui/layout/Scroll.h"
#include"gui/object/List.h"
#include"gui/object/ListItem.h"

class RecipeInfoView
{
	class GoodBtn : public Button
	{
	private:
		Naviframe* mNaviframe;
	public:
		GoodBtn(UILayout parent, Naviframe * naviframe) : Button(parent) {
			mNaviframe = naviframe;
			this->setText("조와요");
			setMaxHint(300, 9999);
		}
		void click()
		{

		}
	};
	class BadBtn : public Button
	{
	private:
		Naviframe* mNaviframe;
	public:
		BadBtn(UILayout parent, Naviframe * naviframe) : Button(parent) {
			mNaviframe = naviframe;
			this->setText("싫어요");
			setMaxHint(300, 9999);
		}
		void click()
		{

		}
	};
	class FavBtn : public Button
	{
	private:
		Naviframe* mNaviframe;
	public:
		FavBtn(UILayout parent, Naviframe * naviframe) : Button(parent) {
			mNaviframe = naviframe;
			this->setText("즐겨찾기");
			setMaxHint(600, 9999);
		}
		void click()
		{

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
		}
		void click()
		{
			mNaviframe->popItem();
		}
	};
private:
	//RecipeItem* mItem;
	Background* mBg;
	Scroll* mScroll;
	Layout* mLayout;
	Box* mBoxInfo;
	Label* mLabel;
	Box* mBox;
	Box* mBox2;

	BackBtn* mBtnBack;
	GoodBtn* mBtnGood;
	BadBtn* mBtnBad;
	FavBtn* mBtnFav;
public:
	RecipeInfoView(Naviframe* parentNavi){
		drawUI(parentNavi);
	}
	void drawUI(Naviframe* parentNavi){
		mBg = new Background(*parentNavi);
		mBg->setColor(255,255,255);

		Button nullBtn;
		parentNavi->addItem("레시피 이름",nullBtn,nullBtn,*mBg,"").setTitleEnalble(TRUE, TRUE);

		mScroll = new Scroll(*mBg);
		elm_object_content_set(mBg->getContent(),mScroll->getContent());

		mLayout = new Layout(*mScroll);
		mLayout->setEDCfile("recipe_info_layout");
		mLayout->setWeightHint(EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
		mLayout->setAlignHint(EVAS_HINT_FILL, EVAS_HINT_EXPAND);
		mScroll->add(*mLayout);

		mBoxInfo = new Box(*mLayout);
		mLayout->setContent("swallow_content", *mBoxInfo);

		//mLabel = new Label(*mBoxInfo);
		//mLabel->setText(mItem->getName());
		//mBoxInfo->addBack(*mLabel);

		mBox = new Box(*mLayout);
		mBox->setHorizontal();
		mBox->setPadding(ELM_SCALE_SIZE(10), 0);
		mLayout->setContent("swallow_buttons_above", *mBox);

		mBtnGood = new GoodBtn(*mBox, parentNavi);
		mBox->addBack(*mBtnGood);
		mBtnBad = new BadBtn(*mBox, parentNavi);
		mBox->addBack(*mBtnBad);


		mBox2 = new Box(*mLayout);
		mLayout->setContent("swallow_buttons_below", *mBox2);

		mBtnFav = new FavBtn(*mBox2, parentNavi);
		mBox2->addBack(*mBtnFav);
		mBtnBack = new BackBtn(*mBox2, parentNavi);
		mBox2->addBack(*mBtnBack);


	}
};
