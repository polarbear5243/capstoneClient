/*
 * Copyright 2014 - 2015 Samsung Electronics Co., Ltd All Rights Reserved
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */

#ifndef NAVI_BAR_TITLE_H_
#define NAVI_BAR_TITLE_H_

#include "view/view.h"
#include <Evas.h>

/**
 * @brief Title widget data
 */
typedef struct _title_widget {
	view_data *view;            /**< Parent view */
} title_widget;

/**
 *@brief Add new title widget to view
 *@param[in]   view     View object.
 *@return Title widget on success or NULL.
 */
title_widget *navi_bar_title_widget_add(view_data *view);

#endif /*NAVI_BAR_TITLE_H_*/
