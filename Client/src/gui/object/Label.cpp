/*
 * Label.cpp
 *
 *  Created on: Mar 17, 2017
 *      Author: YJK
 */
#include"gui/object/Label.h"

Label::Label(UILayout parent)
{
	mContent = elm_label_add(parent.getContent());
	evas_object_show(mContent);
}

void Label::setText(string str)
{
	mTextStyle.setText(str);
	elm_object_text_set(mContent,mTextStyle.getStyleText().c_str());
}
void Label::setSize(string size)
{
	mTextStyle.setSize(size);
	elm_object_text_set(mContent,mTextStyle.getStyleText().c_str());
}
void Label::setAlign(string align)
{
	mTextStyle.setAlign(align);
	elm_object_text_set(mContent,mTextStyle.getStyleText().c_str());
}
void Label::setColor(string color)
{
	mTextStyle.setColor(color);
	elm_object_text_set(mContent,mTextStyle.getStyleText().c_str());
}
