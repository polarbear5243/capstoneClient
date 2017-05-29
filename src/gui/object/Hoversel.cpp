#include "gui/object/Hoversel.h"
using namespace std;

void Hoversel::callback_clicked(void *data, Evas_Object *obj, void *event_info)
{
	((Hoversel *)data)->clicked();
}
void Hoversel::callback_selected(void *data, Evas_Object *obj, void *event_info)
{
	((Hoversel *)data)->selected();
}
void Hoversel::callback_dismissed(void *data, Evas_Object *obj, void *event_info)
{
	((Hoversel *)data)->dismissed();
}

Hoversel::Hoversel(UILayout parent)
{
	mContent = elm_hoversel_add(parent.getContent());
	evas_object_show(mContent);

	evas_object_smart_callback_add(mContent, "clicked", callback_clicked, NULL);
	evas_object_smart_callback_add(mContent, "selected", callback_selected, NULL);
	evas_object_smart_callback_add(mContent, "dismissed", callback_dismissed, NULL);
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


void Hoversel::clicked()
{

}
void Hoversel::selected()
{

}
void Hoversel::dismissed()
{

}


