/*
 * Grid.cpp
 *
 *  Created on: Mar 19, 2017
 *      Author: YJK
 */

#include"gui/layout/Grid.h"

Grid::Grid(UILayout parent){
	mContent = elm_grid_add(parent.getContent());
	evas_object_show(mContent);
}

Grid::~Grid(){

}

void Grid::add(RootObj obj,int x1, int y1, int x2, int y2){
	elm_grid_pack(mContent,obj.getContent(),x1,y1,x2,y2);
}

void Grid::clear(){
	elm_grid_clear(mContent,true);
}

void Grid::release(RootObj obj){
	elm_grid_unpack(mContent,obj.getContent());
}
