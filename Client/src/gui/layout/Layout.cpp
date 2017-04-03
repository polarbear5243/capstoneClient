#include "gui/layout/Layout.h"
#include "string"

using namespace std;

string Layout::mEdcFilePath = "";

void Layout::initEdcFile(string fileName){
	char *res_path = app_get_resource_path();
	char edj_path[1024] = {0, };
	if (res_path) {
		snprintf(edj_path, 1024, "%s%s", res_path, fileName.c_str());
		free(res_path);
	}
	mEdcFilePath = edj_path;
}
Layout::Layout(UILayout parent)
{
	mContent = elm_layout_add(parent.getContent());
	evas_object_show(mContent);
}
void Layout::setEDCfile(string group)
{
	if(!elm_layout_file_set(mContent, mEdcFilePath.c_str(), group.c_str()))
		dlog_print(DLOG_DEBUG, LOG_TAG, "failed to load edc file.");
	else
		dlog_print(DLOG_DEBUG, LOG_TAG, "successed to load edc file");
}
void Layout::setTheme(string klass, string group, string style)
{
	elm_layout_theme_set(mContent, klass.c_str(), group.c_str(), style.c_str());
}

