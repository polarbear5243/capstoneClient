/*
 * Copyright (c) 2015 Samsung Electronics Co., Ltd All Rights Reserved
 *
 *  Licensed under the Apache License, Version 2.0 (the "License");
 *  you may not use this file except in compliance with the License.
 *  You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 *  Unless required by applicable law or agreed to in writing, software
 *  distributed under the License is distributed on an "AS IS" BASIS,
 *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *  See the License for the specific language governing permissions and
 *  limitations under the License.
 *
 */

#include "main.h"

static Evas_Object *ctxpopup = NULL;

/*
 * @brief Function will be operated when naviframe pop its own item
 * @param[in] data The data to be passed to the callback function
 * @param[in] it The item to be popped from naviframe
 */
static Eina_Bool
naviframe_pop_cb(void *data, Elm_Object_Item *it)
{
	if (ctxpopup != NULL) {
		evas_object_del(ctxpopup);
		ctxpopup = NULL;
	}

	return EINA_TRUE;
}

/*
 * @brief Function to calculate position which ctxpopup
 * @param[in] ctxpopup The ctxpopup object need to calculate position
 * @param[in] btn The button object which ctxpopup will be moved on
 */
static void
move_ctxpopup(Evas_Object *ctxpopup, Evas_Object *btn)
{
	Evas_Coord x, y, w , h;
	evas_object_geometry_get(btn, &x, &y, &w, &h);
	evas_object_move(ctxpopup, x + (w / 2), y + (h / 2));
}

/*
 * @brief Function to calculate position which "more/default" style ctxpopup
 * @param[in] ctxpopup The ctxpopup object need to calculate position
 */
static void
move_more_ctxpopup(Evas_Object *ctxpopup)
{
	Evas_Object *win;
	Evas_Coord w, h;
	int pos = -1;

	/* We convince the top widget is a window */
	win = elm_object_top_widget_get(ctxpopup);
	elm_win_screen_size_get(win, NULL, NULL, &w, &h);
	pos = elm_win_rotation_get(win);

	switch (pos) {
	case 0:
	case 180:
		evas_object_move(ctxpopup, (w / 2), h);
		break;
	case 90:
		evas_object_move(ctxpopup,  (h / 2), w);
		break;
	case 270:
		evas_object_move(ctxpopup, (h / 2), w);
		break;
	}
}

/*
 * @brief Function will be operated when ctxpopup is dismissed
 * @param[in] data The data to be passed to the callback function
 * @param[in] obj The Evas object handle to be passed to the callback function
 * @param[in] event_info The system event information
 */
static void
ctxpopup_dismissed_cb(void *data, Evas_Object *obj, void *event_info)
{
	evas_object_del(ctxpopup);
	ctxpopup = NULL;
}

/*
 * @brief Function will be operated when naviframe is resized
 * When naviframe is resized, ctxpopup's position is not appropriate,
 * so ctxpopup's position must be recalculated
 * @param[in] data The data to be passed to the callback function
 * @param[in] e The Evas object handle to be passed to the callback function
 * @param[in] obj The Evas object handle to be passed to the callback function
 * @param[in] event_info The system event information
 */
static void
naviframe_resize_cb(void *data, Evas *e, Evas_Object *obj, void *event_info)
{
	Evas_Object *ctxpopup = data;
	move_more_ctxpopup(ctxpopup);
}

/*
 * @brief Function will be operated when window rotation is changed
 * @param[in] data The data to be passed to the callback function
 * @param[in] obj The Evas object handle to be passed to the callback function
 * @param[in] event_info The system event information
 */
static void
win_rotation_changed_cb(void *data, Evas_Object *obj, void *event_info)
{
	Evas_Object *ctxpopup = data;
	move_more_ctxpopup(ctxpopup);
}

/*
 * @brief Function will be operated when "more/default" style ctxpopup is deleted
 * @param[in] data The data to be passed to the callback function
 * @param[in] e The Evas object handle to be passed to the callback function
 * @param[in] obj The Evas object handle to be passed to the callback function
 * @param[in] event_info The system event information
 */
static void
more_ctxpopup_del_cb(void *data, Evas *e, Evas_Object *obj, void *event_info)
{
	Evas_Object *nf = data;
	evas_object_event_callback_del_full(nf, EVAS_CALLBACK_RESIZE, naviframe_resize_cb, ctxpopup);
}

/*
 * @brief Function will be operated when ctxpopup item is moved
 * @param[in] data The data to be passed to the callback function
 * @param[in] e The Evas object handle to be passed to the callback function
 * @param[in] obj The Evas object handle to be passed to the callback function
 * @param[in] event_info The system event information
 */
static void
item_move_cb(void *data, Evas *e, Evas_Object *obj, void *event_info)
{
	Evas_Coord x, y, w, h;
	evas_object_geometry_get(obj, &x, &y, &w, &h);
	dlog_print(DLOG_INFO, LOG_TAG, "[%s : %d] obj=%p x=%d y=%d w=%d h=%d", __func__, __LINE__, obj, x, y, w, h);
}

/*
 * @brief Function will be operated when ctxpopup item is selected.
 * @param[in] data The data to be passed to the callback function
 * @param[in] obj The Evas object handle to be passed to the callback function
 * @param[in] event_info The system event information
 */
static void
ctxpopup_item_select_cb(void *data, Evas_Object *obj, void *event_info)
{
	const char *label = elm_object_item_text_get((Elm_Object_Item *) event_info);
	if (label) fprintf(stderr, "text(%s) is clicked\n", label);

	Evas_Object *icon = elm_object_item_content_get((Elm_Object_Item *) event_info);
	if (icon) fprintf(stderr, "icon is clicked\n");
}

/*
 * @brief Function to create ctxpopup with text
 * when "Text Only" button is clicked
 * @param[in] data The data to be passed to the callback function
 * @param[in] obj The Evas object handle to be passed to the callback function
 * @param[in] event_info The system event information
 */
static void
btn_text_only_cb(void *data, Evas_Object *obj, void *event_info)
{
	Evas_Object *nf = data;

	/* Delete previous ctxpopup */
	evas_object_del(ctxpopup);

	/* Ctxpopup */
	ctxpopup = elm_ctxpopup_add(nf);
	eext_object_event_callback_add(ctxpopup, EEXT_CALLBACK_BACK, eext_ctxpopup_back_cb, NULL);
	evas_object_smart_callback_add(ctxpopup, "dismissed", ctxpopup_dismissed_cb, NULL);

	/* Text Only Items */
	elm_ctxpopup_item_append(ctxpopup, "Message", NULL, ctxpopup_item_select_cb, NULL);
	elm_ctxpopup_item_append(ctxpopup, "Email", NULL, ctxpopup_item_select_cb, NULL);
	elm_ctxpopup_item_append(ctxpopup, "Facebook", NULL, ctxpopup_item_select_cb, NULL);
	elm_ctxpopup_item_append(ctxpopup, "Flickr", NULL, ctxpopup_item_select_cb, NULL);

	/* Move Ctxpopup */
	move_ctxpopup(ctxpopup, obj);
	evas_object_show(ctxpopup);
}

/*
 * @brief Function to create ctxpopup with icon
 * when "Icon Only" button is clicked
 * @param[in] data The data to be passed to the callback function
 * @param[in] obj The Evas object handle to be passed to the callback function
 * @param[in] event_info The system event information
 */
static void
btn_icon_only_cb(void *data, Evas_Object *obj, void *event_info)
{
	Evas_Object *nf = data;
	Evas_Object *img;
	char buf[PATH_MAX];

	/* Delete previous ctxpopup */
	evas_object_del(ctxpopup);

	/* Ctxpopup */
	ctxpopup = elm_ctxpopup_add(nf);
	eext_object_event_callback_add(ctxpopup, EEXT_CALLBACK_BACK, eext_ctxpopup_back_cb, NULL);
	evas_object_smart_callback_add(ctxpopup, "dismissed", ctxpopup_dismissed_cb, NULL);

	/* Icon Only Items */
	img = elm_image_add(ctxpopup);
	snprintf(buf, sizeof(buf), "%s/contacts_ic_circle_btn_call.png", ICON_DIR);
	elm_image_file_set(img, buf, NULL);
	elm_ctxpopup_item_append(ctxpopup, NULL, img, ctxpopup_item_select_cb, NULL);
	img = elm_image_add(ctxpopup);
	snprintf(buf, sizeof(buf), "%s/contacts_ic_circle_btn_email.png", ICON_DIR);
	elm_image_file_set(img, buf, NULL);
	elm_ctxpopup_item_append(ctxpopup, NULL, img, ctxpopup_item_select_cb, NULL);
	img = elm_image_add(ctxpopup);
	snprintf(buf, sizeof(buf), "%s/contacts_ic_circle_btn_note.png", ICON_DIR);
	elm_image_file_set(img, buf, NULL);
	elm_ctxpopup_item_append(ctxpopup, NULL, img, ctxpopup_item_select_cb, NULL);

	/* Move Ctxpopup */
	move_ctxpopup(ctxpopup, obj);
	evas_object_show(ctxpopup);
}

/*
 * @brief Function to create ctxpopup with icon and text
 * when "Icon + Text" button is clicked
 * @param[in] data The data to be passed to the callback function
 * @param[in] obj The Evas object handle to be passed to the callback function
 * @param[in] event_info The system event information
 */
static void
btn_icon_text_cb(void *data, Evas_Object *obj, void *event_info)
{
	Evas_Object *nf = data;
	Evas_Object *img;
	char buf[PATH_MAX];

	/* Delete previous ctxpopup */
	evas_object_del(ctxpopup);

	/* Ctxpopup */
	ctxpopup = elm_ctxpopup_add(nf);
	eext_object_event_callback_add(ctxpopup, EEXT_CALLBACK_BACK, eext_ctxpopup_back_cb, NULL);
	evas_object_smart_callback_add(ctxpopup, "dismissed", ctxpopup_dismissed_cb, NULL);

	/* Icon + Text Items */
	img = elm_image_add(ctxpopup);
	snprintf(buf, sizeof(buf), "%s/contacts_ic_circle_btn_call.png", ICON_DIR);
	elm_image_file_set(img, buf, NULL);
	elm_ctxpopup_item_append(ctxpopup, "Call", img, ctxpopup_item_select_cb, NULL);
	img = elm_image_add(ctxpopup);
	snprintf(buf, sizeof(buf), "%s/contacts_ic_circle_btn_email.png", ICON_DIR);
	elm_image_file_set(img, buf, NULL);
	elm_ctxpopup_item_append(ctxpopup, "Email", img, ctxpopup_item_select_cb, NULL);
	img = elm_image_add(ctxpopup);
	snprintf(buf, sizeof(buf), "%s/contacts_ic_circle_btn_note.png", ICON_DIR);
	elm_image_file_set(img, buf, NULL);
	elm_ctxpopup_item_append(ctxpopup, "Note", img, ctxpopup_item_select_cb, NULL);

	/* Move Ctxpopup */
	move_ctxpopup(ctxpopup, obj);
	evas_object_show(ctxpopup);
}

/*
 * @brief Function to create "more/default" style ctxpopup
 * when menu key is pressed
 * @param[in] data The data to be passed to the callback function
 * @param[in] obj The Evas object handle to be passed to the callback function
 * @param[in] event_info The system event information
 */
static void
create_ctxpopup_more_button_cb(void *data, Evas_Object *obj, void *event_info)
{
	Evas_Object *it_obj;
	Evas_Object *nf = data;
	Evas_Object *win;
	Elm_Object_Item *it;

	/* Delete previous ctxpopup */
	if (ctxpopup != NULL)
		evas_object_del(ctxpopup);

	/* Ctxpopup */
	ctxpopup = elm_ctxpopup_add(nf);
	elm_ctxpopup_auto_hide_disabled_set(ctxpopup, EINA_TRUE);
	elm_object_style_set(ctxpopup, "more/default");
	eext_object_event_callback_add(ctxpopup, EEXT_CALLBACK_BACK, eext_ctxpopup_back_cb, NULL);
	eext_object_event_callback_add(ctxpopup, EEXT_CALLBACK_MORE, eext_ctxpopup_back_cb, NULL);
	evas_object_smart_callback_add(ctxpopup, "dismissed", ctxpopup_dismissed_cb, NULL);
	evas_object_event_callback_add(ctxpopup, EVAS_CALLBACK_DEL, more_ctxpopup_del_cb, nf);
	evas_object_event_callback_add(nf, EVAS_CALLBACK_RESIZE, naviframe_resize_cb, ctxpopup);

	/* We convince the top widget is a window */
	win = elm_object_top_widget_get(nf);
	evas_object_smart_callback_add(win, "rotation,changed", win_rotation_changed_cb, ctxpopup);

	it = elm_ctxpopup_item_append(ctxpopup, "Add contact", NULL, ctxpopup_item_select_cb, NULL);

	/* This is example to track an object item position */
	it_obj = elm_object_item_track(it);
	evas_object_event_callback_add(it_obj, EVAS_CALLBACK_MOVE, item_move_cb, NULL);

	elm_ctxpopup_item_append(ctxpopup, "Phone calls", NULL, ctxpopup_item_select_cb, NULL);
	elm_ctxpopup_item_append(ctxpopup, "Favorites", NULL, ctxpopup_item_select_cb, NULL);
	elm_ctxpopup_item_append(ctxpopup, "Search", NULL, ctxpopup_item_select_cb, NULL);
	elm_ctxpopup_item_append(ctxpopup, "Dialer", NULL, ctxpopup_item_select_cb, NULL);
	elm_ctxpopup_item_append(ctxpopup, "Add contact", NULL, ctxpopup_item_select_cb, NULL);
	elm_ctxpopup_item_append(ctxpopup, "Phone calls", NULL, ctxpopup_item_select_cb, NULL);
	elm_ctxpopup_item_append(ctxpopup, "Favorites", NULL, ctxpopup_item_select_cb, NULL);
	elm_ctxpopup_item_append(ctxpopup, "Search", NULL, ctxpopup_item_select_cb, NULL);
	elm_ctxpopup_item_append(ctxpopup, "Dialer", NULL, ctxpopup_item_select_cb, NULL);
	elm_ctxpopup_item_append(ctxpopup, "Add contact", NULL, ctxpopup_item_select_cb, NULL);
	elm_ctxpopup_item_append(ctxpopup, "Phone calls", NULL, ctxpopup_item_select_cb, NULL);
	elm_ctxpopup_item_append(ctxpopup, "Favorites", NULL, ctxpopup_item_select_cb, NULL);
	elm_ctxpopup_item_append(ctxpopup, "Search", NULL, ctxpopup_item_select_cb, NULL);
	elm_ctxpopup_item_append(ctxpopup, "Dialer", NULL, ctxpopup_item_select_cb, NULL);

	/* Set ctxpopup's direction priority */
	elm_ctxpopup_direction_priority_set(ctxpopup, ELM_CTXPOPUP_DIRECTION_UP, ELM_CTXPOPUP_DIRECTION_UNKNOWN, ELM_CTXPOPUP_DIRECTION_UNKNOWN, ELM_CTXPOPUP_DIRECTION_UNKNOWN);

	/* Move Ctxpopup */
	move_more_ctxpopup(ctxpopup);
	evas_object_show(ctxpopup);
}

/*
 * @brief Function will be operated when main menu "Ctxpopup" is clicked
 * @param[in] data The data to be passed to the callback function
 * @param[in] obj The Evas object handle to be passed to the callback function
 * @param[in] event_info The system event information
 */
void
ctxpopup_cb(void *data, Evas_Object *obj, void *event_info)
{
	Evas_Object *layout;
	Evas_Object *box;
	Evas_Object *btn;
	Evas_Object *scroller;
	Evas_Object *nf = data;
	Elm_Object_Item *nf_it;

	/* Scroller */
	scroller = elm_scroller_add(nf);
	elm_scroller_bounce_set(scroller, EINA_FALSE, EINA_TRUE);
	elm_scroller_policy_set(scroller, ELM_SCROLLER_POLICY_OFF, ELM_SCROLLER_POLICY_AUTO);

	/* Background Layout */
	layout = elm_layout_add(scroller);
	evas_object_size_hint_weight_set(layout, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_layout_file_set(layout, ELM_DEMO_EDJ, "white_bg_layout");
	elm_object_content_set(scroller, layout);

	/* Box */
	box = elm_box_add(layout);
	evas_object_size_hint_weight_set(box, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(box, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_show(box);
	elm_object_part_content_set(layout, "elm.swallow.content", box);

	/* Text Only */
	layout = elm_layout_add(box);
	elm_layout_file_set(layout, ELM_DEMO_EDJ, "button_layout_1");
	evas_object_size_hint_weight_set(layout, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);

	btn = elm_button_add(layout);
	elm_object_text_set(btn, "Text Only");
	evas_object_smart_callback_add(btn, "clicked", btn_text_only_cb, nf);
	evas_object_show(btn);

	elm_object_part_content_set(layout, "elm.swallow.content", btn);
	evas_object_show(layout);
	elm_box_pack_end(box, layout);

	nf_it = elm_naviframe_item_push(nf, "CtxPopup", NULL, NULL, scroller, NULL);
	elm_naviframe_item_pop_cb_set(nf_it, naviframe_pop_cb, NULL);

	/* Icon Only */
	layout = elm_layout_add(box);
	elm_layout_file_set(layout, ELM_DEMO_EDJ, "button_layout_1");
	evas_object_size_hint_weight_set(layout, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);

	btn = elm_button_add(layout);
	elm_object_text_set(btn, "Icon Only");
	evas_object_smart_callback_add(btn, "clicked", btn_icon_only_cb, nf);
	evas_object_show(btn);

	elm_object_part_content_set(layout, "elm.swallow.content", btn);
	evas_object_show(layout);
	elm_box_pack_end(box, layout);

	/* Icon + Text */
	layout = elm_layout_add(box);
	elm_layout_file_set(layout, ELM_DEMO_EDJ, "button_layout_1");
	evas_object_size_hint_weight_set(layout, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);

	btn = elm_button_add(layout);
	elm_object_text_set(btn, "Icon + Text");
	evas_object_smart_callback_add(btn, "clicked", btn_icon_text_cb, nf);
	evas_object_show(btn);

	elm_object_part_content_set(layout, "elm.swallow.content", btn);
	evas_object_show(layout);
	elm_box_pack_end(box, layout);

	/* This button is set for devices which doesn't have H/W more key. */
	btn = elm_button_add(nf);
	elm_object_style_set(btn, "naviframe/more/default");
	evas_object_smart_callback_add(btn, "clicked", create_ctxpopup_more_button_cb, nf);
	elm_object_item_part_content_set(nf_it, "toolbar_more_btn", btn);
}
