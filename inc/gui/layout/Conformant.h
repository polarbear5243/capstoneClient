#pragma once
#include"UILayout.h"
#include"../Window.h"

class Conformant:public UILayout{
public :
	Conformant(Window win);
	virtual ~Conformant();
	void add(RootObj obj);
};
