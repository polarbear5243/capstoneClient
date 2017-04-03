#include "gui/layout/Box.h"

Box::Box(UILayout parent)
{
	mContent = elm_box_add(parent.getContent());
	evas_object_show(mContent);
}
void Box::setVertical()
{
	elm_box_horizontal_set(mContent, EINA_FALSE);
}
void Box::setHorizontal()
{
	elm_box_horizontal_set(mContent, EINA_TRUE);
}
void Box::addBack(RootObj obj)
{
	elm_box_pack_end(mContent,obj.getContent());
}
void Box::addFront(RootObj obj)
{
	elm_box_pack_start(mContent,obj.getContent());
}
void Box::setPadding(int x, int y)
{
	elm_box_padding_set(mContent,x,y);
}
void Box::clear()
{
	elm_box_clear(mContent);
}
void Box::release(RootObj obj)
{
	elm_box_unpack(mContent,obj.getContent());
}
