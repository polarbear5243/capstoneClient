/*
 * Entry.h
 *
 *  Created on: Mar 23, 2017
 *      Author: YJK
 */
#include<gui/object/Entry.h>

void Entry::callback_change(void *data, Evas_Object *obj, void *event_info){
	((Entry *)data)->change();
}
Entry::Entry(UILayout parent){
	mContent = elm_entry_add(parent.getContent());
	setSingleLine();

	evas_object_show(mContent);

	evas_object_smart_callback_add(mContent,"changed",callback_change,this);
}
string Entry::getText(){
	const char * text = elm_entry_entry_get(mContent);
	string result(text);
	return result;
}
void Entry::setText(string str){
	elm_entry_entry_set(mContent,str.c_str());
}
void Entry::setEnable(){
	elm_object_disabled_set(mContent,EINA_FALSE);
}
void Entry::setDisable(){
	elm_object_disabled_set(mContent,EINA_TRUE);
}
Eina_Bool Entry::isEmpty()
{
	return elm_entry_is_empty(mContent);
}
void Entry::setStyle(string str){
	elm_object_style_set(mContent,str.c_str());
}
void Entry::setPasswdMode(){
	elm_entry_password_set(mContent,EINA_TRUE);
}
void Entry::unSetPasswdMode(){
	elm_entry_password_set(mContent,EINA_FALSE);
}
void Entry::setSingleLine(){
	elm_entry_single_line_set(mContent,EINA_TRUE);
}
void Entry::setMultLine(){
	elm_entry_single_line_set(mContent,EINA_FALSE);
}
void Entry::setScrollable()
{
	elm_entry_scrollable_set(mContent, EINA_TRUE);
}
void Entry::setUnScrollable()
{
	elm_entry_scrollable_set(mContent, EINA_FALSE);
}
void Entry::setInputLayout(Elm_Input_Panel_Layout layout)
{
	elm_entry_input_panel_layout_set(mContent, layout);
}
void Entry::setInputReturnKeyTypeSet(Elm_Input_Panel_Return_Key_Type return_key_type)
{
	elm_entry_input_panel_return_key_type_set(mContent, return_key_type);
}
void Entry::clear(){
	elm_entry_entry_set(mContent,"");
}
void Entry::change(){
	dlog_print(DLOG_INFO, "MY_LOG", "change\n");
}
