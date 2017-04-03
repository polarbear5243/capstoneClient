#include<gui/object/TextStyle.h>
#include<string>

using namespace std;

TextStyle::TextStyle(){
	mSize = "30";
	mAlign = "center";
	mColor = "#000";
	mText = "";
}
void TextStyle::setText(string text){
	mText=text;
}
void TextStyle::setSize(string size)
{
	mSize=size;
}
void TextStyle::setAlign(string align)
{
	mAlign=align;
}
void TextStyle::setColor(string color)
{
	mColor=color;
}
string TextStyle::getStyleText(){
	string result = "<align="+ mAlign + "><font_size=" + mSize +" color=" + mColor + ">" + mText + "</font></align>";
	return result;
}
