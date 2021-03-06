#pragma once
#include"app/fileIO/FileInput.h"

using namespace std;

FileInput::FileInput(string file){
	string defultPath = FILE_ROOT_FOLDER;
	defultPath = defultPath + "/" + FILE_DEFULT_FOLDER;

	if(access(defultPath.c_str(),F_OK) != 0){
		mkdir(defultPath.c_str(),0755);
	}

	mFilePath = defultPath + "/" + file;
	mFile = new ifstream(mFilePath.c_str());

	if(!(*mFile)){
		ofstream(mFilePath.c_str());
		mFile = new ifstream(mFilePath.c_str());
	}
}
string FileInput::read(){
	string str;
	(*mFile) >> str;
	return str;
}
void FileInput::close(){
	mFile->close();
}
FileInput::~FileInput(){
	mFile->close();
	delete mFile;
}
