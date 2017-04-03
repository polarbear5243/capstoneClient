#include "gui/layout/DrawerLayout.h"

DrawerLayout::DrawerLayout(UILayout parent){
	mContent = elm_layout_add(parent.getContent());
	elm_layout_theme_set(mContent, "layout", "drawer", "panel");
	evas_object_show(mContent);
}
void DrawerLayout::addContent(RootObj obj){
	elm_object_part_content_set(mContent,"elm.swallow.content",obj.getContent());
}
void DrawerLayout::addLeft(RootObj obj){
	elm_object_part_content_set(mContent,"elm.swallow.left",obj.getContent());
}
void DrawerLayout::addRight(RootObj obj){
	elm_object_part_content_set(mContent,"elm.swallow.right",obj.getContent());
}
