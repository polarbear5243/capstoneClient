/*
 * Grid.h
 *
 *  Created on: Mar 19, 2017
 *      Author: YJK
 */

#pragma once
#include <gui/layout/UILayout.h>

class Grid:public UILayout{
public :
	Grid(UILayout parent);
	virtual ~Grid();
	void add(RootObj obj, int x1, int y1, int x2, int y2);
	void clear();
	void release(RootObj obj);
};
