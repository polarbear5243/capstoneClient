/*
 * FileIO.h
 *
 *  Created on: Mar 31, 2017
 *      Author: BGKG
 */
#pragma once
#include<string>

using namespace std;

class FileIO{
private:
	FILE* m_fp;
	string mFileName;
	string mFilePath;

	char m_file_path[1024];
	char m_buffer[1024];
	char m_file_name[256];
public:
	FileIO(){

	}
	void set_file_name(char* c){
		strcpy(m_file_name, c);
	}
	void set_file_path(char* file_name){
	    char *resource_path = app_get_data_path();
	    if(!resource_path)
	    	dlog_print(DLOG_INFO, "MY_LOG", "failed to open file.\n");
        snprintf(m_file_path,1000,"%s%s",resource_path, file_name);
        free(resource_path);
	}
	int write_file(const char* buf, char* mod)
	{
		set_file_path(m_file_name);
	    m_fp = fopen(m_file_path, mod);
	    if(m_fp==NULL)
	    {
	    	dlog_print(DLOG_INFO, "MY_LOG", "failed to open file.\n");
	    	return 1;
	    }
	    fputs(buf,m_fp);
	    fclose(m_fp);

	    return 0;
	}
	int read_file(int buffer_size)
	{
		set_file_path(m_file_name);
		m_fp = fopen(m_file_path, "r");
	    if(m_fp==NULL)
	    {
	    	dlog_print(DLOG_INFO, "MY_LOG", "failed to open file.\n");
	    	return 0;
	    }
	    fgets(m_buffer, buffer_size, m_fp);
	    fclose(m_fp);

	    return 1;
	}
	char* get_buffer(){
		return m_buffer;
	}

};
