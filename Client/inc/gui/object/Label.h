// 에디드 박스 만들기 - 참고
//elm_layout_theme_set(editfield, "layout", "editfield", "singleline");

#pragma once
#include <gui/layout/UILayout.h>
#include"TextStyle.h"
#include"Object.h"
#include<string>

using namespace std;

class Label:public Object
{
protected:
	TextStyle mTextStyle;

public:
	Label(UILayout parent);
	void setText(string str);
	void setSize(string size);
	void setAlign(string align);
	void setColor(string color);
};
