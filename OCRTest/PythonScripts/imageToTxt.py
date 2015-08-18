import sys
sys.path.append("C:\\Python27\\Lib")
import os
import time
import glob
import string



def makeFilePath(directory,basename,extension,includeExtension = True):
    if directory != "" and directory[-1] != "/":
        directory += "/"
    directory.replace("/","\\")
    if includeExtension:
        return directory + str(basename) + "." + str(extension)
    return directory + str(basename)

def convertImage(path, density = 600):
    path = path.replace("\\","/")
    filename = path.split("/")[-1]
    dirname = path[0:-1 * len(filename)]
    currExtension = filename.split(".")[-1]
    if not(string.lower(currExtension) in ["tif","png","jpg","jpeg","jpe","jfif","bmp"]):
        raise Exception("Only works with image files")
    filebasename = filename.split(".")[0]
    imgFileName = makeFilePath(dirname,filebasename,currExtension)
    txtFileName = makeFilePath(dirname,filebasename,"txt")
    txtTesseractName = makeFilePath(dirname,filebasename,"txt",False)
    #convertCommand = "convert -monochrome -density " + str(density) + " " + pdfFileName + " " + imgFileName
    #OCRCommand = "tesseract " + imgFileName + " " + txtTesseractName
    OCRCommand = "\"C:\\Program Files (x86)\\Tesseract-OCR\\tesseract.exe\" " + imgFileName + " " + txtTesseractName
    startTime = time.time()    
    print "-----------------------------------------------------------"
    print "\nBeginning Optical Character Recognition of " + imgFileName
    print "-----------------------------------------------------------"
    print "COMMAND: " + OCRCommand
    tesRes = os.system(OCRCommand)
    #tesRes = 999
    print "-----------------------------------------------------------"
    endOCRTime = time.time()
    print "OCR complete. Output in " + txtFileName + ". Return Value of " + str(tesRes) + ".\n\n" 
    print "File complete. Recognized " + imgFileName + " to " + txtFileName + " in " + str(endOCRTime-startTime) + " seconds"
    
def main():
    print "----Welcome to Image to TXT converter----"
    #mode = input("1) single conversion, 2) all pdf conversion --> ")
    #if mode == 1:
    path = sys.argv[0]
    convertImage(path)
    #path = raw_input("Path of directory with /? - ")
    #convertAllPdfFiles(path)
    print "Job complete."

main()