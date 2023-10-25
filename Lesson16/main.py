import cv2

img = cv2.imread('02.png')
imgWidth, imgHeight, _ = img.shape
img = cv2.resize(img, (imgHeight//4, imgWidth//4))
cv2.imshow('zero two', img)
cv2.waitKey(0)
