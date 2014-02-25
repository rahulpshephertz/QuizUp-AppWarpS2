/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package quizserver;

/**
 *
 * @author rahulwindows
 */
public class QuizConstants {

    public static final String SERVER_NAME = "AppWarpS2";
    // Message Constants
    public static final byte RESULT_GAME_OVER = 3;
    public static final byte RESULT_USER_LEFT = 4;
    // error code
    public static final int SUBMIT_ANSWER = 111;
    public static final int INVALID_ANSWER = 121;
    public static final int MINIMUM_USER_PERROOM= 2;
    public static final int MAXIMUM_USER_PERROOM = 2;
    // GAME_STATUS
    public static final int STOPPED = 71;
    public static final int RUNNING = 72;
    public static final int PAUSED = 73;
    public static final int RESUMED = 74;
    public static final int FINISHED = 75;
}
