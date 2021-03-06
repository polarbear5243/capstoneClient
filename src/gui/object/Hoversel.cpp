#include "gui/object/Hoversel.h"
using namespace std;

void Hoversel::callback_clicked(void *data, Evas_Object *obj, void *event_info)
{
	((Hoversel *)data)->clicked(event_info);
}
void Hoversel::callback_selected(void *data, Evas_Object *obj, void *event_info)
{
	((Hoversel *)data)->selected(event_info);
}
void Hoversel::callback_dismissed(void *data, Evas_Object *obj, void *event_info)
{
	((Hoversel *)data)->dismissed(event_info);
}

Hoversel::Hoversel(UILayout parent)
{
	mContent = elm_hoversel_add(parent.getContent());
	evas_object_show(mContent);

	evas_object_smart_callback_add(mContent, "clicked", callback_clicked, this);
	evas_object_smart_callback_add(mContent, "selected", callback_selected, this);
	evas_object_smart_callback_add(mContent, "dismissed", callback_dismissed, this);
}
void Hoversel::setName(string name)
{
	elm_object_text_set(mContent, name.c_str());
}
void Hoversel::setParent(Elm_Hoversel *obj, Evas_Object *parent)
{
	elm_hoversel_hover_parent_set(mContent, parent);
}
void Hoversel::addItem(string name)
{
	elm_hoversel_item_add(mContent, name.c_str(), NULL, ELM_ICON_NONE, NULL, NULL);
}


void Hoversel::clicked(void * event_info)
{

}
void Hoversel::selected(void * event_info)
{

}
void Hoversel::dismissed(void * event_info)
{

}


