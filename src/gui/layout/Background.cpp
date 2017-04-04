#include "gui/layout/Background.h"

Background::Background(UILayout parent)
{
	mContent = elm_bg_add(parent.getContent());
	evas_object_show(mContent);
}

void Background::setColor(int r, int g, int b)
{
	elm_bg_color_set(mContent, r, g, b);
}

void Background::setOption(Elm_Bg_Option option)
{
	elm_bg_option_set(mContent, option);
}
void Background::setImgFile(const std::string file, const std::string group)
{
	elm_bg_file_set(mContent, file.c_str(), group.c_str());
}
void Background::add(RootObj obj){
	elm_object_content_set(mContent, obj.getContent());
}
