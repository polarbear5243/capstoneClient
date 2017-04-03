/*
 * DrawerLayout.h
 *
 *  Created on: Mar 20, 2017
 *      Author: YJK
 */
#pragma once
#include <gui/layout/UILayout.h>

class DrawerLayout:public UILayout{
public:
	DrawerLayout(UILayout parent);
	void addContent(RootObj obj);
//	void addBg();
	void addLeft(RootObj obj);
	void addRight(RootObj obj);
};
