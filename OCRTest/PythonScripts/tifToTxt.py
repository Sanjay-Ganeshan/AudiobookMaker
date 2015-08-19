import sys
sys.path.append("C:\\Python27\\Lib")
import os
import time
import glob



def makeFilePath(directory,basename,extension,includeExtension = True):
    if directory != "" and directory[-1] != "/":
        directory += "/"
    directory.replace("/","\\")
    if includeExtension:
        return directory + str(basename) + "." + str(extension)
    return directory + str(basename)

def convertAllTifFiles(path = ""):
    allTifs = glob.glob(path+"*.tif")
    print "Found " + str(len(allTifs)) + " tif files: " + str(allTifs) 
    for eachFilePath in allTifs:
        convertTif(eachFilePath)
        print "\n"

def convertTif(path, density = 600):
    path = path.replace("\\","/")
    filename = path.split("/")[-1]
    dirname = path[0:-1 * len(filename)]
    currExtension = filename.split(".")[-1]
    if currExtension != "tif":
        raise Exception("Only works with TIF files")
    filebasename = filename.split(".")[0]
    tifFileName = makeFilePath(dirname,filebasename,"tif")
    txtFileName = makeFilePath(dirname,filebasename,"txt")
    txtTesseractName = makeFilePath(dirname,filebasename,"txt",False)
    #convertCommand = "convert -monochrome -density " + str(density) + " " + pdfFileName + " " + tifFileName
    #OCRCommand = "tesseract " + tifFileName + " " + txtTesseractName
    OCRCommand = "\"Extras\\Tesseract-OCR\\tesseract.exe\" " + tifFileName + " " + txtTesseractName
    startTime = time.time()    
    print "-----------------------------------------------------------"
    print "\nBeginning Optical Character Recognition of " + tifFileName
    print "-----------------------------------------------------------"
    print "COMMAND: " + OCRCommand
    tesRes = os.system(OCRCommand)
    #tesRes = 999
    print "-----------------------------------------------------------"
    endOCRTime = time.time()
    print "OCR complete. Output in " + txtFileName + ". Return Value of " + str(tesRes) + ".\n\n" 
    print "File complete. Recognized " + tifFileName + " to " + txtFileName + " in " + str(endOCRTime-startTime) + " seconds"
    
def main():
    print "----Welcome to TIF to TXT converter----"
    #mode = input("1) single conversion, 2) all pdf conversion --> ")
    #if mode == 1:
    path = sys.argv[0]
    convertTif(path)
    #path = raw_input("Path of directory with /? - ")
    #convertAllPdfFiles(path)
    print "Job complete."

main()