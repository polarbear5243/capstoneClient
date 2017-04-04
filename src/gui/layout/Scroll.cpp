/*
 * Scroll.cpp
 *
 *  Created on: Mar 19, 2017
 *      Author: YJK
 */

#include "gui/layout/Scroll.h"

const int Scroll::DEFAULT_STYLE = 0;
const int Scroll::HANDLER_STYLE = 1;

void Scroll::callback_anim_stop(void *data, Evas_Object *obj, void *event_info){
	((Scroll *)data)->anim_stop();
}

Scroll::Scroll(UILayout parent){
	mContent = elm_scroller_add(parent.getContent());
	evas_object_show(mContent);

	evas_object_smart_callback_add(mContent,"scroll,anim,stop",callback_anim_stop,this);
}
Scroll::~Scroll(){
}
void Scroll::add(RootObj obj){
	elm_object_content_set(mContent,obj.getContent());
}
void Scroll::getCurrentPage(int* h_pagenumber, int *v_pagenumber)
{
	elm_scroller_current_page_get(mContent, h_pagenumber, v_pagenumber);
}
/*
void Scroll::setStyle(int style){
	if(style==1)
		elm_object_style_set(mContent,"handler");
	else
		elm_object_style_set(mContent,"default");
}
*/
void Scroll::setLoop(Eina_Bool loop_h, Eina_Bool loop_v)
{
	elm_scroller_loop_set(mContent, loop_h, loop_v);
}
void Scroll::setPageRelationVal(double h_pagerel, double v_pagerel)
{
	elm_scroller_page_relative_set(mContent, h_pagerel, h_pagerel);
}
void Scroll::setPageSize(Evas_Coord h_pagesize, Evas_Coord v_pagesize)
{
	elm_scroller_page_size_set(mContent, h_pagesize, v_pagesize);
}
void Scroll::setPolicy(Elm_Scroller_Policy policy_h, Elm_Scroller_Policy policy_v)
{
	elm_scroller_policy_set(mContent, policy_h, policy_v);
}
void Scroll::setScrollLimit(int page_limit_h, int page_limit_v)
{
	elm_scroller_page_scroll_limit_set(mContent, page_limit_h, page_limit_v);
}
void Scroll::setLockYaxis(Eina_Bool lock)
{
	elm_object_scroll_lock_y_set(mContent, lock);
}
void Scroll::setSingleDirection(Elm_Scroller_Single_Direction single_dir)
{
	elm_scroller_single_direction_set(mContent, single_dir);
}


void Scroll::anim_stop(){

}
