import cv2


face_cascades = cv2.CascadeClassifier(cv2.data.haarcascades + 'haarcascade_frontalcatface_extended.xml')
cap = cv2.VideoCapture(0)

while True:
    _, frame = cap.read()
    frame_gray = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)

    faces = face_cascades.detectMultiScale(frame_gray)

    for (x, y, h, w) in faces:
        cv2.rectangle(frame, (x, y), (x+w, y + h), (0, 255, 0), 1)

    cv2.imshow('muzzle', frame)

    if cv2.waitKey(1) & 0xff == ord('q'):
        break
