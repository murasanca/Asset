// Murat Sancak

#if UNITY_EDITOR||UNITY_EDITOR_64||UNITY_EDITOR_WIN

// Murat Sancak

namespace murasanca
{
    public class Screenshot:UnityEditor.EditorWindow
    {
        private bool
            l=true,   // l: Left.
            r=false; // r: Right.

        private int pu; // pu: Pop-up.

        private string
            e=string.Empty,   // e: Extension.
            n=string.Empty,  // n: Name.
            p=string.Empty; // p: Path.

        private UnityEngine.GameObject c; // c: Camera.

        private UnityEngine.GUIContent m; // m: murasanca.

        private readonly string[] o=new string[3]{"Data","Desktop","Other"}; // o: Options.

        private static UnityEditor.EditorWindow eW; // eW: Editor Window.

        private static UnityEngine.Vector2Int
            h=new(256,128),  // h: Horizontal.
            v=new(256,512); // v: Vertical.

        // Murat Sancak

        [UnityEditor.MenuItem("Murat Sancak/Screenshot",false,0)]
        private static void S() // S: Screenshot.
        {
            eW=GetWindow<Screenshot>(true,"Screenshot by Murat Sancak",true);
            eW.maxSize=eW.minSize=h;
            eW.position=UnityEngine.Rect.zero;
            eW.Show();
        }

        // Murat Sancak

        private void Awake()=>m=new UnityEngine.GUIContent("Screenshot by Murat Sancak",UnityEditor.AssetDatabase.LoadAssetAtPath<UnityEngine.Texture2D>("Assets/Murat Sancak/Screenshot/Sprite/Murat Sancak.png"));

        // Murat Sancak

        private void OnGUI()
        {
            // Camera Label Field.
            UnityEditor.EditorGUI.LabelField(new UnityEngine.Rect(8,8,position.width-16,16),"Camera",UnityEditor.EditorStyles.centeredGreyMiniLabel);
            // Camera Object Field.
            if
            (
                (
                    c=c
                        ?UnityEditor.EditorGUI.ObjectField(new UnityEngine.Rect(8,32,position.width-16,16),c,typeof(UnityEngine.GameObject),true)as UnityEngine.GameObject
                        :UnityEditor.EditorGUI.ObjectField(new UnityEngine.Rect(8,32,position.width-16,16),UnityEngine.Camera.main.gameObject,typeof(UnityEngine.GameObject),true)as UnityEngine.GameObject
                )!
                &&
                c.TryGetComponent(out UnityEngine.Camera _)
            )
            {
                maxSize=minSize=v;

                // Path Label Field.
                UnityEditor.EditorGUI.LabelField(new UnityEngine.Rect(8,56,position.width-16,16),"Path",UnityEditor.EditorStyles.centeredGreyMiniLabel);
                // Path Popup
                switch(pu=UnityEditor.EditorGUI.Popup(new UnityEngine.Rect(8,80,position.width-16,16),pu,o,UnityEditor.EditorStyles.popup))
                {
                    case 0:
                        p="Assets/Murat Sancak/Screenshot";
                        break;
                    case 1:
                        p=System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop);
                        break;
                    case 2:
                        // Path Text Field.
                        p=p is ""
                            ?UnityEditor.EditorGUI.TextArea(new UnityEngine.Rect(8,104,position.width-16,32),string.Concat(UnityEngine.Application.dataPath,"/Murat Sancak/Screenshot"),UnityEditor.EditorStyles.textArea)
                            :UnityEditor.EditorGUI.TextArea(new UnityEngine.Rect(8,104,position.width-16,32),p,UnityEditor.EditorStyles.textArea);
                        break;
                    default:
                        break;
                }

                if(pu is 2)
                {
                    // Name Label Field.
                    UnityEditor.EditorGUI.LabelField(new UnityEngine.Rect(8,144,position.width-16,16),"Name",UnityEditor.EditorStyles.centeredGreyMiniLabel);
                    // Name Text Field.
                    n=n is ""
                        ?UnityEditor.EditorGUI.TextArea(new UnityEngine.Rect(8,168,position.width-16,16),"Screenshot",UnityEditor.EditorStyles.textArea)
                        :UnityEditor.EditorGUI.TextArea(new UnityEngine.Rect(8,168,position.width-16,16),n,UnityEditor.EditorStyles.textArea);

                    // Extension Label Field.
                    UnityEditor.EditorGUI.LabelField(new UnityEngine.Rect(8,192,position.width-16,16),"Extension",UnityEditor.EditorStyles.centeredGreyMiniLabel);
                    // Extension Text Field.
                    e=e is ""
                        ?UnityEditor.EditorGUI.TextArea(new UnityEngine.Rect(8,216,position.width-16,16),"png",UnityEditor.EditorStyles.textArea)
                        :UnityEditor.EditorGUI.TextArea(new UnityEngine.Rect(8,216,position.width-16,16),e,UnityEditor.EditorStyles.textArea);

                    // Eye Label Field.
                    UnityEditor.EditorGUI.LabelField(new UnityEngine.Rect(8,240,position.width-16,16),"Eye",UnityEditor.EditorStyles.centeredGreyMiniLabel);
                    // Left Toggle.
                    l=UnityEditor.EditorGUI.ToggleLeft(new UnityEngine.Rect(8,264,position.width/2-16,16),"Left",l,UnityEditor.EditorStyles.centeredGreyMiniLabel);
                    // Right Toggle.
                    r=UnityEditor.EditorGUI.ToggleLeft(new UnityEngine.Rect(position.width/2+8,264,position.width/2-16,16),"Right",r,UnityEditor.EditorStyles.centeredGreyMiniLabel);

                    // Resolution Label Field
                    UnityEditor.EditorGUI.LabelField(new UnityEngine.Rect(8,288,position.width-16,16),"Resolution",UnityEditor.EditorStyles.centeredGreyMiniLabel);
                    // X Label Field.
                    UnityEditor.EditorGUI.LabelField(new UnityEngine.Rect(8,312,position.width/2-16,16),string.Concat("X:\t",c.GetComponent<UnityEngine.Camera>().pixelWidth),UnityEditor.EditorStyles.centeredGreyMiniLabel);
                    // Y Label Field.
                    UnityEditor.EditorGUI.LabelField(new UnityEngine.Rect(position.width/2+8,312,position.width/2-16,16),string.Concat("Y:\t",c.GetComponent<UnityEngine.Camera>().pixelHeight),UnityEditor.EditorStyles.centeredGreyMiniLabel);

                    // Screenshot Label Field.
                    UnityEditor.EditorGUI.LabelField(new UnityEngine.Rect(8,336,position.width-16,16),"Screenshot",UnityEditor.EditorStyles.centeredGreyMiniLabel);
                    // File Label Field.
                    UnityEditor.EditorGUI.LabelField(new UnityEngine.Rect(8,360,position.width-16,32),R('/',string.Concat(p,'/',n,'.',e)),UnityEditor.EditorStyles.wordWrappedMiniLabel);
                }
                else // popup is 0 or 1.
                {
                    // Name Label Field.
                    UnityEditor.EditorGUI.LabelField(new UnityEngine.Rect(8,104,position.width-16,16),"Name",UnityEditor.EditorStyles.centeredGreyMiniLabel);
                    // Name Text Field.
                    n=n is ""
                        ?UnityEditor.EditorGUI.TextArea(new UnityEngine.Rect(8,128,position.width-16,16),"Screenshot",UnityEditor.EditorStyles.textArea)
                        :UnityEditor.EditorGUI.TextArea(new UnityEngine.Rect(8,128,position.width-16,16),n,UnityEditor.EditorStyles.textArea);

                    // Extension Label Field.
                    UnityEditor.EditorGUI.LabelField(new UnityEngine.Rect(8,152,position.width-16,16),"Extension",UnityEditor.EditorStyles.centeredGreyMiniLabel);
                    // Extension Text Field.
                    e=e is ""
                        ?UnityEditor.EditorGUI.TextArea(new UnityEngine.Rect(8,176,position.width-16,16),"png",UnityEditor.EditorStyles.textArea)
                        :UnityEditor.EditorGUI.TextArea(new UnityEngine.Rect(8,176,position.width-16,16),e,UnityEditor.EditorStyles.textArea);

                    // Eye Label Field.
                    UnityEditor.EditorGUI.LabelField(new UnityEngine.Rect(8,200,position.width-16,16),"Eye",UnityEditor.EditorStyles.centeredGreyMiniLabel);
                    // Left Toggle.
                    l=UnityEditor.EditorGUI.ToggleLeft(new UnityEngine.Rect(8,224,position.width/2-16,16),"Left",l,UnityEditor.EditorStyles.centeredGreyMiniLabel);
                    // Right Toggle.
                    r=UnityEditor.EditorGUI.ToggleLeft(new UnityEngine.Rect(position.width/2+8,224,position.width/2-16,16),"Right",r,UnityEditor.EditorStyles.centeredGreyMiniLabel);

                    // Resolution Label Field
                    UnityEditor.EditorGUI.LabelField(new UnityEngine.Rect(8,248,position.width-16,16),"Resolution",UnityEditor.EditorStyles.centeredGreyMiniLabel);
                    // X Label Field.
                    UnityEditor.EditorGUI.LabelField(new UnityEngine.Rect(8,272,position.width/2-16,16),string.Concat("X:\t",c.GetComponent<UnityEngine.Camera>().pixelWidth),UnityEditor.EditorStyles.centeredGreyMiniLabel);
                    // Y Label Field.
                    UnityEditor.EditorGUI.LabelField(new UnityEngine.Rect(position.width/2+8,272,position.width/2-16,16),string.Concat("Y:\t",c.GetComponent<UnityEngine.Camera>().pixelHeight),UnityEditor.EditorStyles.centeredGreyMiniLabel);

                    // Screenshot Label Field.
                    UnityEditor.EditorGUI.LabelField(new UnityEngine.Rect(8,296,position.width-16,16),"Screenshot",UnityEditor.EditorStyles.centeredGreyMiniLabel);
                    // File Label Field.
                    UnityEditor.EditorGUI.LabelField(new UnityEngine.Rect(8,320,position.width-16,72),R('/',string.Concat(p,'/',n,'.',e)),UnityEditor.EditorStyles.wordWrappedMiniLabel);
                }

                // Capture Screenshot Button.
                if(UnityEngine.GUI.Button(new UnityEngine.Rect(8,position.height-112,position.width-16,32),"Capture Screenshot"))
                    if(System.IO.Directory.Exists(R('\\',p)))
                    {
                        if(l)
                            UnityEngine.ScreenCapture.CaptureScreenshot(R('\\',string.Concat(p,'\\',n,'.',e)),UnityEngine.ScreenCapture.StereoScreenCaptureMode.LeftEye);
                        else if(r)
                            UnityEngine.ScreenCapture.CaptureScreenshot(R('\\',string.Concat(p,'\\',n,'.',e)),UnityEngine.ScreenCapture.StereoScreenCaptureMode.RightEye);
                        else if(l&&r)
                            UnityEngine.ScreenCapture.CaptureScreenshot(R('\\',string.Concat(p,'\\',n,'.',e)),UnityEngine.ScreenCapture.StereoScreenCaptureMode.BothEyes);
                        else
                            UnityEngine.ScreenCapture.CaptureScreenshot(R('\\',string.Concat(p,'\\',n,'.',e)),1);
                    }
                    else
                        UnityEngine.Debug.LogWarning(string.Concat("Directory.Exists(",p,"):\t",System.IO.Directory.Exists(R('\\',p))));
            }
            else
                maxSize=minSize=h;

            // Drop Shadow Label.
            UnityEditor.EditorGUI.DropShadowLabel(new UnityEngine.Rect(position.width/2-32,position.height-72,64,64),m,UnityEditor.EditorStyles.centeredGreyMiniLabel);
        }

        private void OnInspectorUpdate()
        {
            m=new UnityEngine.GUIContent(UnityEditor.AssetDatabase.LoadAssetAtPath<UnityEngine.Texture2D>("Assets/Murat Sancak/Screenshot/Sprite/Murat Sancak.png"));

            Repaint();
        }

        private void OnProjectChange()=>UnityEditor.AssetDatabase.Refresh();

        private void OnSelectionChange()=>UnityEditor.AssetDatabase.Refresh();

        // Murat Sancak

        private string R(char c,string s)=>c is '/'?s.Replace('\\','/'):s.Replace('/','\\'); // R: Replace, c: Character, s: String.
    }
}
#endif

// Murat Sancak