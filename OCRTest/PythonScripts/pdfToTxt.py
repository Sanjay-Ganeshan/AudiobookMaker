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

def convertAllPdfFiles(path = ""):
    allPdfs = glob.glob(path+"*.pdf")
    print "Found " + str(len(allPdfs)) + " pdf files: " + str(allPdfs) 
    for eachFilePath in allPdfs:
        convertPdf(eachFilePath)
        print "\n"

def convertPdf(path, density = 400):
    path = path.replace("\\","/")
    filename = path.split("/")[-1]
    dirname = path[0:-1 * len(filename)]
    currExtension = filename.split(".")[-1]
    if currExtension != "pdf":
        raise Exception("Only works with PDF files")
    filebasename = filename.split(".")[0]
    pdfFileName = makeFilePath(dirname,filebasename,"pdf")
    tifFileName = makeFilePath(dirname,filebasename,"tif")
    txtFileName = makeFilePath(dirname,filebasename,"txt")
    txtTesseractName = makeFilePath(dirname,filebasename,"txt",False)
    #convertCommand = "convert -monochrome -density " + str(density) + " " + pdfFileName + " " + tifFileName
    #OCRCommand = "tesseract " + tifFileName + " " + txtTesseractName
    #f = open("../helloTHERE.txt","w")
    #f.write("Sup")
    #f.close()
    convertCommand = "\"Extras\\ImageMagick-6.9.2-Q16\\convert.exe\" -monochrome -density " + str(density) + " " + pdfFileName + " " + tifFileName
    OCRCommand = "\"Extras\\Tesseract-OCR\\tesseract.exe\" " + tifFileName + " " + txtTesseractName
    print "\nBeginning Conversion of " + pdfFileName
    print "-----------------------------------------------------------"
    print "COMMAND: " + convertCommand
    startTime = time.time()
    convRes = os.system(convertCommand)
    endConvertTime = time.time()
    print "-----------------------------------------------------------"
    print "Image conversion complete. Return Value of " + str(convRes) + ". \n\nBeginning Optical Character Recognition of " + tifFileName
    print "-----------------------------------------------------------"
    print "COMMAND: " + convertCommand
    tesRes = os.system(OCRCommand)
    #tesRes = 999
    print "-----------------------------------------------------------"
    endOCRTime = time.time()
    print "OCR complete. Output in " + txtFileName + ". Return Value of " + str(tesRes) + ".\n\n" 
    print "Converted " + pdfFileName + " to " + tifFileName + " in " + str(endConvertTime-startTime) + " seconds"
    print "Recognized " + tifFileName + " to " + txtFileName + " in " + str(endOCRTime-endConvertTime) + " seconds"
    print "File complete: " + pdfFileName + " to " + txtFileName + " in " + str(endOCRTime-startTime) + " seconds"
    
def main():
    print "----Welcome to PDF to TXT converter----"
    #mode = input("1) single conversion, 2) all pdf conversion --> ")
    #if mode == 1:
    path = sys.argv[0]
    convertPdf(path)
    #path = raw_input("Path of directory with /? - ")
    #convertAllPdfFiles(path)
    print "Job complete."

main()