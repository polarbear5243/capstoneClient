#include "gui/layout/NaviItem.h"

using namespace std;

Eina_Bool NaviItem::static_pop_cb(void *data, Elm_Object_Item *it) {
	ui_app_exit();
	return EINA_FALSE;
}
NaviItem::NaviItem(){
	mContent = NULL;
}
NaviItem::NaviItem(Evas_Object * na_it){
	mContent = na_it;
}
void NaviItem::setStyle(NaviItem item, string style){
	elm_naviframe_item_style_set(item.getContent(),style.c_str());
}
void NaviItem::setTitleEnalble(bool enabled, bool transition){
	Eina_Bool p1 = (enabled == true)?EINA_TRUE:EINA_FALSE;
	Eina_Bool p2 = (transition == true)?EINA_TRUE:EINA_FALSE;

	elm_naviframe_item_title_enabled_set(mContent,p1,p2);
}
void NaviItem::setTitle(string str){
	elm_object_item_part_text_set(mContent, "title", str.c_str());
}
void NaviItem::setSubTitle(string str){
	elm_object_item_part_text_set(mContent, "subtitle", str.c_str());
}
void NaviItem::setLeftTopBtn(Button btn){
	elm_object_item_part_content_set(mContent,"title_left_btn", btn.getContent());
}
void NaviItem::setRightTopBtn(Button btn){
	elm_object_item_part_content_set(mContent,"title_right_btn", btn.getContent());
}
void NaviItem::unSetLeftTopBtn(){
	elm_object_item_part_content_unset(mContent,"title_left_btn");
}
void NaviItem::unSetRightTopBtn(){
	elm_object_item_part_content_unset(mContent,"title_right_btn");
}
void NaviItem::setFinalNavi(){
	elm_naviframe_item_pop_cb_set(mContent,static_pop_cb,NULL);
}
void NaviItem::unSetFinalNavi(){
	elm_naviframe_item_pop_cb_set(mContent,NULL,NULL);
}
NaviItem::~NaviItem(){

}
