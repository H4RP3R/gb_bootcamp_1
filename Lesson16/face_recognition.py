import cv2


img = cv2.imread('Thompson_and_Ritchie_source_unknown.jpg')
img_gray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)  # конвертировать изображении в черно-белое

face_cascades = cv2.CascadeClassifier(cv2.data.haarcascades + 'haarcascade_frontalface_default.xml')
faces = face_cascades.detectMultiScale(img_gray)

for (x, y, h, w) in faces:
    cv2.rectangle(img, (x, y), (x+w, y + h), (0, 255, 0), 1)

cv2.imshow('Face', img)
cv2.waitKey(0)
