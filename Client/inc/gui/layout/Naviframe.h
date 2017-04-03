/*
 * Naviframe.h
 *
 *  Created on: Mar 19, 2017
 *      Author: YJK
 */
#pragma once
#include <gui/layout/UILayout.h>
#include <gui/layout/NaviItem.h>
#include <gui/object/Button.h>
#include <string>

using namespace std;

class Naviframe:public UILayout{
private:
	static void	HWbackBtn_callback(void *data, Evas_Object *obj, void *event_info);
public:
	Naviframe(UILayout parent);
	NaviItem addItem(string title,Button prevBtn,Button nextBtn,RootObj obj,string itemStyle);
	void setAutoBackBtn();
	void unSetAutioBackBtn();
	void popItem();
	virtual ~Naviframe();
};
