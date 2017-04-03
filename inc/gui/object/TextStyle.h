#pragma once
#include<string>

using namespace std;

class TextStyle{
protected:
	string mSize;
	string mAlign;
	string mColor;
	string mText;
public:
	TextStyle();
	void setText(string text);
	void setSize(string size);
	void setAlign(string align);
	void setColor(string color);
	string getStyleText();
};
