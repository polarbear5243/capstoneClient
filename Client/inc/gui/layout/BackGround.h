#pragma once
#include <gui/layout/UILayout.h>
#include <string>

class Background:public UILayout{
public :
	Background(UILayout parent);
	void setColor(int r, int g, int b);
	void setOption(Elm_Bg_Option option);
	void setImgFile(const std::string file, const std::string group);
};
