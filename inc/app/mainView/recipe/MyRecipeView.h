/*
 * MyRecipeView.h
 *
 *  Created on: Apr 1, 2017
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

class MyRecipeView
{
private:
	Scroll* mScroller;
	Box* mBox;
	Label* mLabelFav;
	Toolbar* mToolbar;

	Evas_Object* mRect;
	Evas_Coord mW;
	Evas_Coord mH;
	void min_set(Evas_Object *obj, Evas_Object *box, Evas_Coord w, Evas_Coord h)
	{
		Evas_Object *table;

		table = elm_table_add(box);
		evas_object_show(table);

		mRect = evas_object_rectangle_add(evas_object_evas_get(table));
		evas_object_size_hint_min_set(mRect, w, h);
		evas_object_size_hint_weight_set(mRect, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
		evas_object_size_hint_align_set(mRect, EVAS_HINT_FILL, EVAS_HINT_FILL);
		elm_table_pack(table, mRect, 0, 0, 1, 1);

		evas_object_size_hint_weight_set(obj, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
		evas_object_size_hint_align_set(obj, EVAS_HINT_FILL, EVAS_HINT_FILL);
		elm_table_pack(table, obj, 0, 0, 1, 1);

		evas_object_size_hint_weight_set(table, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
		evas_object_size_hint_align_set(table, EVAS_HINT_FILL, EVAS_HINT_FILL);
		elm_box_pack_end(box, table);
	}
public:
	static void cb(void *data, Evas_Object *obj, void *event_info)
	{
		return;
	}
	MyRecipeView(Box* parent,Evas_Coord w, Evas_Coord h){
		mW = w;
		mH = h;
		drawUI(parent);
	}
	void drawUI(Box* parent){

		mLabelFav = new Label(*parent);
		mLabelFav->setAlignHint(0.05, EVAS_HINT_FILL);
		mLabelFav->setWeightHint(EVAS_HINT_EXPAND, 0.0);
		mLabelFav->setText("<b>RECIPE</b>");
		parent->addBack(*mLabelFav);

		mScroller = new Scroll(*parent);
		mScroller->setPolicy(ELM_SCROLLER_POLICY_OFF, ELM_SCROLLER_POLICY_AUTO);
		mScroller->setSingleDirection(ELM_SCROLLER_SINGLE_DIRECTION_HARD);
		parent->addBack(*mScroller);

		mBox = new Box(*mScroller);
		mBox->setWeightHint(EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
		mBox->setAlignHint(EVAS_HINT_FILL, EVAS_HINT_FILL);
		elm_object_content_set(mScroller->getContent(), mBox->getContent());

		min_set(mScroller->getContent(), parent->getContent(), 0, 0);
		evas_object_size_hint_min_set(mRect, mW, mH);
	}
};
