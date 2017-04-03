#pragma once
#include <gui/layout/UILayout.h>

class Box:public UILayout{
public :
	Box(UILayout parent);
	void setVertical();
	void setHorizontal();
	void addBack(RootObj obj);
	void addFront(RootObj obj);
	void setPadding(int x, int y);
	void clear();
	void release(RootObj obj);
};
