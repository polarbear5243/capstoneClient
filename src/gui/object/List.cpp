#include"gui/object/List.h"

void List::list_selected_cb(void *data, Evas_Object *obj, void *event_info){
	Elm_Object_Item *it = (Elm_Object_Item*)event_info;
	elm_list_item_selected_set(it, EINA_FALSE);
}

List::List(UILayout parent){
	mContent = elm_list_add(parent.getContent());
	elm_list_go(mContent);

	elm_list_mode_set(mContent, ELM_LIST_COMPRESS);
	evas_object_smart_callback_add(mContent, "selected", list_selected_cb, this);

	mItemList = list<ListItem *>();
}

void List::addItem(ListItem * item){
	item->mContent = elm_list_item_append(mContent,item->mTitle.c_str(),NULL,NULL,ListItem::selected_cb,item);
	mItemList.push_back(item);
}

void List::clear(){
	list<ListItem *>::iterator it;
	for(it=mItemList.begin();it != mItemList.end();it++)
		(*it)->mContent=NULL;
	mItemList.clear();

	elm_list_clear(mContent);
}

void List::deleteItem(ListItem * item){
	list<ListItem *>::iterator it;
	for(it=mItemList.begin();it != mItemList.end();it++)
		if((*it) == item){
			elm_object_item_del(item->mContent);
			mItemList.erase(it);
			item->mContent=NULL;
		}
}
List::~List(){

}
