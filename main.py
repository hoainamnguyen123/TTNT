import cv2
import mediapipe as mp
mp_drawing_util = mp.solutions.drawing_utils
mp_drawing_style = mp.solutions.drawing_styles
mp_hand = mp.solutions.hands
hands = mp_hand.Hands(
    model_complexity=0,
    min_detection_confidence=0.5,
    min_tracking_confidence=0.5
)
cap = cv2.VideoCapture(0)
while cap.isOpened():
    success,img = cap.read()
    if not success:
        break
    img = cv2.cvtColor(img,cv2.COLOR_BGR2RGB)
    result = hands.process(img)
    img = cv2.cvtColor(img,cv2.COLOR_BGR2RGB)
    label = ""
    if result.multi_hand_landmarks:
        myHand = []
        for idx,hand in enumerate(result.multi_hand_landmarks):

            mp_drawing_util.draw_landmarks(img,hand,mp_hand.HAND_CONNECTIONS,
                mp_drawing_style.get_default_hand_landmarks_style(),
                mp_drawing_style.get_default_hand_connections_style()
            )

            for id,lm in enumerate(hand.landmark):
                h, w, _ = img.shape
                myHand.append([int(lm.x*w),int(lm.y*h)])
            if (myHand[8][1] < myHand[6][1] and myHand[20][1] < myHand[18][1]
            and myHand[12][1]> myHand[10][1] and myHand[16][1] > myHand[14][1]
            and myHand[4][0] > myHand[2][0]):
                label = "I LOVE YOU"
            #một số xử lí khác....
            if (myHand[8][1] > myHand[5][1] and myHand[20][1] > myHand[18][1]
            and myHand[12][1] > myHand[10][1] and myHand[16][1] > myHand[14][1]
            and myHand[4][0] < myHand[2][0] ):
                label = "Nam dam"

            if(myHand[8][1] > myHand[5][1] and myHand[20][1] > myHand[18][1]
            and myHand[12][1] < myHand[10][1] and myHand[16][1] > myHand[14][1]
            and myHand[4][0] > myHand[2][0]):
                label = "Toi ghet ban"
            if(myHand[8][1] < myHand[5][1] and myHand[20][1] > myHand[18][1]
            and myHand[12][1] < myHand[10][1] and myHand[16][1] > myHand[14][1]
            and myHand[4][0] < myHand[2][0]):
                label = "Hi chao cau"
            if (myHand[8][0] > myHand[3][0] and myHand[20][1] < myHand[18][1]
            and myHand[12][1] < myHand[10][1] and myHand[16][1] < myHand[14][1]
            and myHand[4][0] > myHand[2][0]):
                label = "OKEY !!"
            #thatim
            #like
            if (myHand[8][0] < myHand[6][0] and myHand[12][0] < myHand[10][0]
            and myHand[16][0] < myHand[14][0] and myHand[20][0] < myHand[18][0]
            and myHand[4][1] < myHand[2][1]):
                label = " LIKE "
            #dislike
            if (myHand[8][0] < myHand[6][0] and myHand[12][0] < myHand[10][0]
            and myHand[16][0] < myHand[14][0] and myHand[20][0] < myHand[18][0]
            and myHand[4][1] > myHand[2][1]):
                label = "Dislike"
            if (myHand[8][1] > myHand[5][1] and myHand[12][1] > myHand[9][1]
            and myHand[16][1] > myHand[13][1] and myHand[20][1] > myHand[17][1]
            and myHand[2][0] < myHand[4][0]):
                label = "turn right"
            if (myHand[8][1] > myHand[5][1] and myHand[12][1] > myHand[9][1]
            and myHand[16][1] > myHand[13][1] and myHand[20][1] > myHand[17][1]
            and myHand[4][0] < myHand[2][0] and not myHand[4][0] > myHand[13][0] and not myHand[4][1]>myHand[8][1]):
                label = "turn left"
            if (myHand[8][1] < myHand[5][1] and myHand[20][1] > myHand[18][1]
                and myHand[12][1] > myHand[10][1] and myHand[16][1] > myHand[14][1]
                and myHand[4][0] < myHand[2][0]):
                label = "Forward"
            if (myHand[8][1] > myHand[5][1] and myHand[20][1] < myHand[18][1] and myHand[12][1] < myHand[10][1] and
                myHand[16][1] < myHand[14][1] and myHand[4][1] > myHand[2][1]):
                label = "down"

    cv2.putText(img,str(label),(50,50),cv2.FONT_ITALIC,1,(255, 8, 90),2,cv2.LINE_AA)
    cv2.imshow("Hai ban tay cua em",img)
    key = cv2.waitKey(1)
    if key == 27:
        break
cap.release()

