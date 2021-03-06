#pragma once
#include"app/fileIO/FileOutput.h"

using namespace std;

FileOutput::FileOutput(string file){
	string defultPath = FILE_ROOT_FOLDER;
	defultPath = defultPath + "/" + FILE_DEFULT_FOLDER;

	if(access(defultPath.c_str(),F_OK) != 0){
		mkdir(defultPath.c_str(),0755);
	}

	mFilePath = defultPath + "/" + file;
	mFile = new ofstream(mFilePath.c_str());

}
void FileOutput::writeln(string str){
	(*mFile) << str << endl;
}
void FileOutput::write(string str){
	(*mFile) << str;
}
void FileOutput::close(){
	mFile->close();
}
FileOutput::~FileOutput(){
	mFile->close();
	delete mFile;
}
