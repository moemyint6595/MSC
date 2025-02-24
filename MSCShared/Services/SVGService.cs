using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MSCShared.Services
{
    public class SVGService
    {
        public static RenderFragment CrossIcon(int w, int h)
        {
            return (builder) =>
            {
                builder.AddMarkupContent(0, string.Format(@"
       	            <svg fill=""currentcolor"" width=""{0}"" height=""{1}"" viewBox=""0 0 32 32""><g id=""SVGRepo_bgCarrier"" stroke-width=""0""></g><g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""></g><g id=""SVGRepo_iconCarrier""> <path d=""M18.8,16l5.5-5.5c0.8-0.8,0.8-2,0-2.8l0,0C24,7.3,23.5,7,23,7c-0.5,0-1,0.2-1.4,0.6L16,13.2l-5.5-5.5 c-0.8-0.8-2.1-0.8-2.8,0C7.3,8,7,8.5,7,9.1s0.2,1,0.6,1.4l5.5,5.5l-5.5,5.5C7.3,21.9,7,22.4,7,23c0,0.5,0.2,1,0.6,1.4 C8,24.8,8.5,25,9,25c0.5,0,1-0.2,1.4-0.6l5.5-5.5l5.5,5.5c0.8,0.8,2.1,0.8,2.8,0c0.8-0.8,0.8-2.1,0-2.8L18.8,16z""></path> </g>
                    </svg>
                ", w, h));
            };
        }

        public static RenderFragment HeartUnfill(int w, int h)
        {
            return (builder) =>
            {
                builder.AddMarkupContent(0, string.Format(@"
       	            <svg width=""{0}"" height=""{1}"" viewBox=""0 0 24 24"" fill=""none""><g id=""SVGRepo_bgCarrier"" stroke-width=""0""></g><g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""></g><g id=""SVGRepo_iconCarrier""> <path fill-rule=""evenodd"" clip-rule=""evenodd"" d=""M1 8.5C1 5.21475 3.31333 2 7 2C8.70883 2 9.92877 2.48125 10.8649 3.2079C11.3091 3.55266 11.6802 3.94929 11.9974 4.33639C12.311 3.95011 12.6785 3.55357 13.1186 3.20977C14.0531 2.47979 15.275 2 17 2C20.7289 2 23 5.22013 23 8.5C23 11.8412 21.3259 14.6994 19.2285 16.9297C17.1279 19.1634 14.523 20.8565 12.4472 21.8944C12.1657 22.0352 11.8343 22.0352 11.5528 21.8944C9.47698 20.8565 6.8721 19.1634 4.77151 16.9297C2.67415 14.6994 1 11.8412 1 8.5ZM7 4C4.68667 4 3 6.02986 3 8.5C3 11.1445 4.32585 13.5363 6.22849 15.5596C7.9833 17.4256 10.1612 18.9027 12 19.8754C13.8388 18.9027 16.0167 17.4256 17.7715 15.5596C19.6741 13.5363 21 11.1445 21 8.5C21 6.02448 19.3463 4 17 4C15.6874 4 14.907 4.35067 14.3497 4.78592C13.8333 5.18934 13.4736 5.68102 13.045 6.26703C12.9669 6.37374 12.8866 6.48357 12.8026 6.59656C12.6139 6.85039 12.3163 7 12 7C11.6837 7 11.3861 6.85039 11.1974 6.59656C11.1256 6.49997 11.0562 6.4055 10.9884 6.31318C10.5465 5.71179 10.1717 5.20159 9.63856 4.78779C9.07355 4.34922 8.29117 4 7 4Z"" fill=""currentcolor""></path> </g></svg>
                ", w, h));
            };
        }
        public static RenderFragment HeartFill(int w, int h)
        {
            return (builder) =>
            {
                builder.AddMarkupContent(0, string.Format(@"
       	            <svg fill=""currentcolor"" width=""{0}"" height=""{1}"" viewBox=""0 0 64 64"" version=""1.1"" xml:space=""preserve"" style=""fill-rule:evenodd;clip-rule:evenodd;stroke-linejoin:round;stroke-miterlimit:2;""><g id=""SVGRepo_bgCarrier"" stroke-width=""0""></g><g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""></g><g id=""SVGRepo_iconCarrier""> <rect id=""Icons"" x=""-64"" y=""-256"" width=""1280"" height=""800"" style=""fill:none;""></rect> <g id=""Icons1"" serif:id=""Icons""> <g id=""Strike""> </g> <g id=""H1""> </g> <g id=""H2""> </g> <g id=""H3""> </g> <g id=""list-ul""> </g> <g id=""hamburger-1""> </g> <g id=""hamburger-2""> </g> <g id=""list-ol""> </g> <g id=""list-task""> </g> <g id=""trash""> </g> <g id=""vertical-menu""> </g> <g id=""horizontal-menu""> </g> <g id=""sidebar-2""> </g> <g id=""Pen""> </g> <g id=""Pen1"" serif:id=""Pen""> </g> <g id=""clock""> </g> <g id=""external-link""> </g> <g id=""hr""> </g> <g id=""info""> </g> <g id=""warning""> </g> <g id=""plus-circle""> </g> <g id=""minus-circle""> </g> <g id=""vue""> </g> <g id=""cog""> </g> <g id=""logo""> </g> <path d=""M43.046,9.05c5.137,0.117 9.856,3.451 11.782,8.485c2.392,6.249 0.678,13.452 -2.495,19.624c-3.792,7.375 -10.79,12.703 -17.966,17.288c0,0 -2.796,1.351 -5.516,-0.403c-9.246,-6.021 -17.877,-13.963 -20.318,-24.82c-1.857,-8.258 1.161,-18.596 10.582,-20.034c4.72,-0.721 11.109,2.766 12.808,5.869c1.657,-3.095 6.565,-5.884 10.694,-6.008c0.215,-0.002 0.214,-0.003 0.429,-0.001Z"" style=""fill-rule:nonzero;""></path> <g id=""radio-check""> </g> <g id=""eye-slash""> </g> <g id=""eye""> </g> <g id=""toggle-off""> </g> <g id=""shredder""> </g> <g id=""spinner--loading--dots-"" serif:id=""spinner [loading, dots]""> </g> <g id=""react""> </g> <g id=""check-selected""> </g> <g id=""turn-off""> </g> <g id=""code-block""> </g> <g id=""user""> </g> <g id=""coffee-bean""> </g> <g id=""coffee-beans""> <g id=""coffee-bean1"" serif:id=""coffee-bean""> </g> </g> <g id=""coffee-bean-filled""> </g> <g id=""coffee-beans-filled""> <g id=""coffee-bean2"" serif:id=""coffee-bean""> </g> </g> <g id=""clipboard""> </g> <g id=""clipboard-paste""> </g> <g id=""clipboard-copy""> </g> <g id=""Layer1""> </g> </g> </g></svg>
                ", w, h));
            };
        }
        public static RenderFragment CarvonDown(int w, int h)
        {
            return (builder) =>
            {
                builder.AddMarkupContent(0, string.Format(@"
       	            <svg fill=""currentcolor"" width=""{0}"" height=""{1}"" viewBox=""0 0 32 32"" version=""1.1"" ><g id=""SVGRepo_bgCarrier"" stroke-width=""0""></g><g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""></g><g id=""SVGRepo_iconCarrier""> <path d=""M0.256 8.606c0-0.269 0.106-0.544 0.313-0.75 0.412-0.412 1.087-0.412 1.5 0l14.119 14.119 13.913-13.912c0.413-0.412 1.087-0.412 1.5 0s0.413 1.088 0 1.5l-14.663 14.669c-0.413 0.413-1.088 0.413-1.5 0l-14.869-14.869c-0.213-0.213-0.313-0.481-0.313-0.756z""></path> </g></svg>
                ", w, h));
            };
        }

        public static RenderFragment FreeIcon(int w, int h)
        {
            return (builder) =>
            {
                builder.AddMarkupContent(0, string.Format(@"
       	            <svg fill=""currentcolor"" version=""1.1"" id=""Layer_1"" viewBox=""0 0 512 512"" xml:space=""preserve"" width=""{0}"" height=""{1}""><g id=""SVGRepo_bgCarrier"" stroke-width=""0""></g><g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""></g><g id=""SVGRepo_iconCarrier""> <g> <g> <polygon points=""389.565,205.913 389.565,172.522 300.522,172.522 300.522,339.478 389.565,339.478 389.565,306.087 333.913,306.087 333.913,272.696 389.565,272.696 389.565,239.304 333.913,239.304 333.913,205.913 ""></polygon> </g> </g> <g> <g> <polygon points=""100.174,205.913 100.174,172.522 0,172.522 0,339.478 33.391,339.478 33.391,272.696 100.174,272.696 100.174,239.304 33.391,239.304 33.391,205.913 ""></polygon> </g> </g> <g> <g> <polygon points=""512,205.913 512,172.522 422.957,172.522 422.957,339.478 512,339.478 512,306.087 456.348,306.087 456.348,272.696 512,272.696 512,239.304 456.348,239.304 456.348,205.913 ""></polygon> </g> </g> <g> <g> <path d=""M133.565,172.522v166.957h33.391v-66.783h33.391v33.391h33.391v-33.391H256V172.522H133.565z M222.609,239.304h-55.652 v-33.391h55.652V239.304z""></path> </g> </g> <g> <g> <rect x=""233.739"" y=""306.087"" width=""33.391"" height=""33.391""></rect> </g> </g> </g></svg>
                ", w, h));
            };
        }
        public static RenderFragment ArrowBackIcon(int w, int h)
        {
            return (builder) =>
            {
                builder.AddMarkupContent(0, string.Format(@"
       	            <svg width=""{0}"" height=""{1}"" viewBox=""0 0 24 24"" fill=""none"">
                        <g id=""SVGRepo_bgCarrier"" stroke-width=""0""></g><g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""></g>
                        <g id=""SVGRepo_iconCarrier""> <path d=""M6 12H18M6 12L11 7M6 12L11 17"" stroke=""currentcolor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round""></path> </g>
                     </svg>
                ", w, h));
            };
        }

        public static RenderFragment VIPIcon(int w, int h)
        {
            return (builder) =>
            {
                builder.AddMarkupContent(0, string.Format(@"
       	           <svg width=""{0}"" height=""{1}"" viewBox=""0 0 24 24"" fill=""currentcolor""><g id=""SVGRepo_bgCarrier"" stroke-width=""0""></g><g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""></g><g id=""SVGRepo_iconCarrier""> <g> <path fill=""none"" d=""M0 0h24v24H0z""></path> <path d=""M3 3h18a1 1 0 0 1 1 1v16a1 1 0 0 1-1 1H3a1 1 0 0 1-1-1V4a1 1 0 0 1 1-1zm8 5.5v7h2v-7h-2zm-.285 0H8.601l-1.497 4.113L5.607 8.5H3.493l2.611 6.964h2L10.715 8.5zm5.285 5h1.5a2.5 2.5 0 1 0 0-5H14v7h2v-2zm0-2v-1h1.5a.5.5 0 1 1 0 1H16z""></path> </g> </g></svg>
                ", w, h));
            };
        }
        public static RenderFragment EditIcon(int w, int h)
        {
            return (builder) =>
            {
                builder.AddMarkupContent(0, string.Format(@"
       	           <svg width=""{0}"" height=""{1}"" viewBox=""0 0 20 20"" fill=""currentcolor"" transform=""matrix(-1, 0, 0, 1, 0, 0)""><g id=""SVGRepo_bgCarrier"" stroke-width=""0""></g><g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""></g><g id=""SVGRepo_iconCarrier""><path d=""M14.846 1.403l3.752 3.753.625-.626A2.653 2.653 0 0015.471.778l-.625.625zm2.029 5.472l-3.752-3.753L1.218 15.028 0 19.998l4.97-1.217L16.875 6.875z"" fill=""currentcolor""></path></g></svg>
                ", w, h));
            };
        }

        public static RenderFragment SadFace(int w, int h)
        {
            return (builder) =>
            {
                builder.AddMarkupContent(0, string.Format(@"
       	          <svg width=""{0}"" height=""{1}"" viewBox=""0 0 24 24"" fill=""none""><g id=""SVGRepo_bgCarrier"" stroke-width=""0""></g><g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""></g><g id=""SVGRepo_iconCarrier""> <path fill-rule=""evenodd"" clip-rule=""evenodd"" d=""M12 22C17.5228 22 22 17.5228 22 12C22 6.47715 17.5228 2 12 2C6.47715 2 2 6.47715 2 12C2 17.5228 6.47715 22 12 22ZM15 12C15.5523 12 16 11.3284 16 10.5C16 9.67157 15.5523 9 15 9C14.4477 9 14 9.67157 14 10.5C14 11.3284 14.4477 12 15 12ZM10 10.5C10 11.3284 9.55228 12 9 12C8.44772 12 8 11.3284 8 10.5C8 9.67157 8.44772 9 9 9C9.55228 9 10 9.67157 10 10.5ZM8.39747 17.4466C8.64413 17.7794 9.11385 17.8492 9.44661 17.6025C10.175 17.0627 11.0541 16.75 12 16.75C12.9459 16.75 13.825 17.0627 14.5534 17.6025C14.8862 17.8492 15.3559 17.7794 15.6025 17.4466C15.8492 17.1138 15.7794 16.6441 15.4466 16.3975C14.4742 15.6767 13.285 15.25 12 15.25C10.715 15.25 9.5258 15.6767 8.55339 16.3975C8.22062 16.6441 8.15082 17.1138 8.39747 17.4466Z"" fill=""currentcolor""></path> </g></svg>
                ", w, h));
            };
        }

        public static RenderFragment LogOutIcon(int w, int h)
        {
            return (builder) =>
            {
                builder.AddMarkupContent(0, string.Format(@"
       	          <svg width=""{0}"" height=""{1}"" viewBox=""0 0 24 24"" fill=""none""><g id=""SVGRepo_bgCarrier"" stroke-width=""0""></g><g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""></g><g id=""SVGRepo_iconCarrier""> <path d=""M8.00195 7C8.01406 4.82497 8.11051 3.64706 8.87889 2.87868C9.75757 2 11.1718 2 14.0002 2H15.0002C17.8286 2 19.2429 2 20.1215 2.87868C21.0002 3.75736 21.0002 5.17157 21.0002 8V16C21.0002 18.8284 21.0002 20.2426 20.1215 21.1213C19.2429 22 17.8286 22 15.0002 22H14.0002C11.1718 22 9.75757 22 8.87889 21.1213C8.11051 20.3529 8.01406 19.175 8.00195 17"" stroke=""currentcolor"" stroke-width=""1.5"" stroke-linecap=""round""></path> <path d=""M8 19.5C5.64298 19.5 4.46447 19.5 3.73223 18.7678C3 18.0355 3 16.857 3 14.5V9.5C3 7.14298 3 5.96447 3.73223 5.23223C4.46447 4.5 5.64298 4.5 8 4.5"" stroke=""currentcolor"" stroke-width=""1.5""></path> <path d=""M15 12L6 12M6 12L8 14M6 12L8 10"" stroke=""#1C274C"" stroke-width=""1.5"" stroke-linecap=""round"" stroke-linejoin=""round""></path> </g></svg>
                ", w, h));
            };
        }

        public static RenderFragment VisibleIcon(int w, int h)
        {
            return (builder) =>
            {
                builder.AddMarkupContent(0, string.Format(@"
       	          <svg fill=""currentcolor"" width=""{0}"" height=""{1}"" viewBox=""0 0 64 64"" version=""1.1"" xml:space=""preserve""  style=""fill-rule:evenodd;clip-rule:evenodd;stroke-linejoin:round;stroke-miterlimit:2;""><g id=""SVGRepo_bgCarrier"" stroke-width=""0""></g><g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""></g><g id=""SVGRepo_iconCarrier""> <rect id=""Icons"" x=""-896"" y=""-256"" width=""1280"" height=""800"" style=""fill:none;""></rect> <g id=""Icons1"" serif:id=""Icons""> <g id=""Strike""> </g> <g id=""H1""> </g> <g id=""H2""> </g> <g id=""H3""> </g> <g id=""list-ul""> </g> <g id=""hamburger-1""> </g> <g id=""hamburger-2""> </g> <g id=""list-ol""> </g> <g id=""list-task""> </g> <g id=""trash""> </g> <g id=""vertical-menu""> </g> <g id=""horizontal-menu""> </g> <g id=""sidebar-2""> </g> <g id=""Pen""> </g> <g id=""Pen1"" serif:id=""Pen""> </g> <g id=""clock""> </g> <g id=""external-link""> </g> <g id=""hr""> </g> <g id=""info""> </g> <g id=""warning""> </g> <g id=""plus-circle""> </g> <g id=""minus-circle""> </g> <g id=""vue""> </g> <g id=""cog""> </g> <g id=""logo""> </g> <g id=""radio-check""> </g> <g id=""eye-slash""> </g> <g id=""eye""> <path d=""M32.513,13.926c10.574,0.15 19.141,9.894 23.487,18.074c0,0 -1.422,2.892 -2.856,4.895c-0.694,0.969 -1.424,1.913 -2.191,2.826c-0.547,0.65 -1.112,1.283 -1.698,1.898c-5.237,5.5 -12.758,9.603 -20.7,8.01c-8.823,-1.77 -15.732,-9.498 -20.058,-17.629c0,0 1.248,-2.964 2.69,-4.964c0.646,-0.897 1.324,-1.77 2.034,-2.617c0.544,-0.649 1.108,-1.282 1.691,-1.897c4.627,-4.876 10.564,-8.63 17.601,-8.596Zm-0.037,4c-5.89,-0.022 -10.788,3.267 -14.663,7.35c-0.527,0.555 -1.035,1.127 -1.527,1.713c-0.647,0.772 -1.265,1.569 -1.854,2.386c-0.544,0.755 -1.057,1.805 -1.451,2.59c3.773,6.468 9.286,12.323 16.361,13.742c6.563,1.317 12.688,-2.301 17.016,-6.846c0.529,-0.555 1.04,-1.128 1.534,-1.715c0.7,-0.833 1.366,-1.694 1.999,-2.579c0.557,-0.778 1.144,-1.767 1.588,-2.567c-3.943,-6.657 -10.651,-13.944 -19.003,-14.074Z""></path> <path d=""M32.158,23.948c4.425,0 8.018,3.593 8.018,8.017c0,4.425 -3.593,8.017 -8.018,8.017c-4.424,0 -8.017,-3.592 -8.017,-8.017c0,-4.424 3.593,-8.017 8.017,-8.017Zm0,4.009c2.213,0 4.009,1.796 4.009,4.008c0,2.213 -1.796,4.009 -4.009,4.009c-2.212,0 -4.008,-1.796 -4.008,-4.009c0,-2.212 1.796,-4.008 4.008,-4.008Z""></path> </g> <g id=""toggle-off""> </g> <g id=""shredder""> </g> <g id=""spinner--loading--dots-"" serif:id=""spinner [loading, dots]""> </g> <g id=""react""> </g> <g id=""check-selected""> </g> <g id=""turn-off""> </g> <g id=""code-block""> </g> <g id=""user""> </g> <g id=""coffee-bean""> </g> <g id=""coffee-beans""> <g id=""coffee-bean1"" serif:id=""coffee-bean""> </g> </g> <g id=""coffee-bean-filled""> </g> <g id=""coffee-beans-filled""> <g id=""coffee-bean2"" serif:id=""coffee-bean""> </g> </g> <g id=""clipboard""> </g> <g id=""clipboard-paste""> </g> <g id=""clipboard-copy""> </g> <g id=""Layer1""> </g> </g> </g></svg>
                ", w, h));
            };
        }

        public static RenderFragment InVisibleIcon(int w, int h)
        {
            return (builder) =>
            {
                builder.AddMarkupContent(0, string.Format(@"
       	          <svg fill=""currentcolor"" width=""{1}"" height=""{1}"" viewBox=""0 0 64 64"" version=""1.1"" xml:space=""preserve"" style=""fill-rule:evenodd;clip-rule:evenodd;stroke-linejoin:round;stroke-miterlimit:2;""><g id=""SVGRepo_bgCarrier"" stroke-width=""0""></g><g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""></g><g id=""SVGRepo_iconCarrier""> <rect id=""Icons"" x=""-960"" y=""-256"" width=""1280"" height=""800"" style=""fill:none;""></rect> <g id=""Icons1"" serif:id=""Icons""> <g id=""Strike""> </g> <g id=""H1""> </g> <g id=""H2""> </g> <g id=""H3""> </g> <g id=""list-ul""> </g> <g id=""hamburger-1""> </g> <g id=""hamburger-2""> </g> <g id=""list-ol""> </g> <g id=""list-task""> </g> <g id=""trash""> </g> <g id=""vertical-menu""> </g> <g id=""horizontal-menu""> </g> <g id=""sidebar-2""> </g> <g id=""Pen""> </g> <g id=""Pen1"" serif:id=""Pen""> </g> <g id=""clock""> </g> <g id=""external-link""> </g> <g id=""hr""> </g> <g id=""info""> </g> <g id=""warning""> </g> <g id=""plus-circle""> </g> <g id=""minus-circle""> </g> <g id=""vue""> </g> <g id=""cog""> </g> <g id=""logo""> </g> <g id=""radio-check""> </g> <g id=""eye-slash""> <path d=""M13.673,10.345l-3.097,3.096l39.853,39.854l3.097,-3.097l-39.853,-39.853Z""></path> <path d=""M17.119,19.984l2.915,2.915c-3.191,2.717 -5.732,6.099 -7.374,9.058l-0.005,0.01c4.573,7.646 11.829,14.872 20.987,13.776c2.472,-0.296 4.778,-1.141 6.885,-2.35l2.951,2.95c-4.107,2.636 -8.815,4.032 -13.916,3.342c-9.198,-1.244 -16.719,-8.788 -21.46,-17.648c2.226,-4.479 5.271,-8.764 9.017,-12.053Zm6.63,-4.32c2.572,-1.146 5.355,-1.82 8.327,-1.868c0.165,-0.001 2.124,0.092 3.012,0.238c0.557,0.092 1.112,0.207 1.659,0.35c8.725,2.273 15.189,10.054 19.253,17.653c-1.705,3.443 -3.938,6.398 -6.601,9.277l-2.827,-2.827c1.967,-2.12 3.622,-4.161 4.885,-6.45c0,0 -1.285,-2.361 -2.248,-3.643c-0.619,-0.824 -1.27,-1.624 -1.954,-2.395c-0.54,-0.608 -2.637,-2.673 -3.136,-3.103c-3.348,-2.879 -7.279,-5.138 -11.994,-5.1c-1.826,0.029 -3.582,0.389 -5.249,0.995l-3.127,-3.127Z"" style=""fill-rule:nonzero;""></path> <path d=""M25.054,27.92l2.399,2.398c-0.157,0.477 -0.243,0.987 -0.243,1.516c0,2.672 2.169,4.841 4.841,4.841c0.529,0 1.039,-0.085 1.516,-0.243l2.399,2.399c-1.158,0.65 -2.494,1.02 -3.915,1.02c-4.425,0 -8.017,-3.592 -8.017,-8.017c0,-1.421 0.371,-2.756 1.02,-3.914Zm6.849,-4.101c0.049,-0.001 0.099,-0.002 0.148,-0.002c4.425,0 8.017,3.593 8.017,8.017c0,0.05 0,0.099 -0.001,0.148l-8.164,-8.163Z""></path> </g> <g id=""eye""> </g> <g id=""toggle-off""> </g> <g id=""shredder""> </g> <g id=""spinner--loading--dots-"" serif:id=""spinner [loading, dots]""> </g> <g id=""react""> </g> <g id=""check-selected""> </g> <g id=""turn-off""> </g> <g id=""code-block""> </g> <g id=""user""> </g> <g id=""coffee-bean""> </g> <g id=""coffee-beans""> <g id=""coffee-bean1"" serif:id=""coffee-bean""> </g> </g> <g id=""coffee-bean-filled""> </g> <g id=""coffee-beans-filled""> <g id=""coffee-bean2"" serif:id=""coffee-bean""> </g> </g> <g id=""clipboard""> </g> <g id=""clipboard-paste""> </g> <g id=""clipboard-copy""> </g> <g id=""Layer1""> </g> </g> </g></svg>
                ", w, h));
            };
        }

        public static RenderFragment WarningIcon(int w, int h)
        {
            return (builder) =>
            {
                builder.AddMarkupContent(0, string.Format(@"
       	              <svg width=""{0}"" height=""{1}"" viewBox=""0 0 1024 1024"" fill=""currentcolor"">
                        <g id=""SVGRepo_bgCarrier"" stroke-width=""0""></g><g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""></g>
                        <g id=""SVGRepo_iconCarrier""><path fill=""currentcolor"" d=""M512 64a448 448 0 1 1 0 896 448 448 0 0 1 0-896zm0 192a58.432 58.432 0 0 0-58.24 63.744l23.36 256.384a35.072 35.072 0 0 0 69.76 0l23.296-256.384A58.432 58.432 0 0 0 512 256zm0 512a51.2 51.2 0 1 0 0-102.4 51.2 51.2 0 0 0 0 102.4z""></path></g>
                      </svg>
                ", w, h));
            };
        }

        public static RenderFragment RecentIcon(int w, int h)
        {
            return (builder) =>
            {
                builder.AddMarkupContent(0, string.Format(@"
       	             <svg width=""{0}"" height=""{1}"" viewBox=""0 0 24 24"" id=""_24x24_On_Light_Recent"" data-name=""24x24/On Light/Recent"" fill=""currentcolor78""><g id=""SVGRepo_bgCarrier"" stroke-width=""0""></g><g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""></g><g id=""SVGRepo_iconCarrier""> <rect id=""view-box"" width=""24"" height=""24"" fill=""none""></rect> <path id=""Shape"" d=""M9.682,18.75a.75.75,0,0,1,.75-.75,8.25,8.25,0,1,0-6.189-2.795V12.568a.75.75,0,0,1,1.5,0v4.243a.75.75,0,0,1-.751.75H.75a.75.75,0,0,1,0-1.5H3a9.75,9.75,0,1,1,7.433,3.44A.75.75,0,0,1,9.682,18.75Zm2.875-4.814L9.9,11.281a.754.754,0,0,1-.22-.531V5.55a.75.75,0,1,1,1.5,0v4.889l2.436,2.436a.75.75,0,1,1-1.061,1.06Z"" transform=""translate(1.568 2.25)"" fill=""currentcolor""></path> </g></svg>
                ", w, h));
            };
        }

        public static RenderFragment TrashIcon(int w, int h)
        {
            return (builder) =>
            {
                builder.AddMarkupContent(0, string.Format(@"
       	            <svg width=""{0}"" height=""{1}"" viewBox=""0 0 24 24"" fill=""none"" ><g id=""SVGRepo_bgCarrier"" stroke-width=""0""></g><g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""></g><g id=""SVGRepo_iconCarrier""> <path d=""M3 6.38597C3 5.90152 3.34538 5.50879 3.77143 5.50879L6.43567 5.50832C6.96502 5.49306 7.43202 5.11033 7.61214 4.54412C7.61688 4.52923 7.62232 4.51087 7.64185 4.44424L7.75665 4.05256C7.8269 3.81241 7.8881 3.60318 7.97375 3.41617C8.31209 2.67736 8.93808 2.16432 9.66147 2.03297C9.84457 1.99972 10.0385 1.99986 10.2611 2.00002H13.7391C13.9617 1.99986 14.1556 1.99972 14.3387 2.03297C15.0621 2.16432 15.6881 2.67736 16.0264 3.41617C16.1121 3.60318 16.1733 3.81241 16.2435 4.05256L16.3583 4.44424C16.3778 4.51087 16.3833 4.52923 16.388 4.54412C16.5682 5.11033 17.1278 5.49353 17.6571 5.50879H20.2286C20.6546 5.50879 21 5.90152 21 6.38597C21 6.87043 20.6546 7.26316 20.2286 7.26316H3.77143C3.34538 7.26316 3 6.87043 3 6.38597Z"" fill=""currentcolor""></path> <path fill-rule=""evenodd"" clip-rule=""evenodd"" d=""M11.5956 22.0001H12.4044C15.1871 22.0001 16.5785 22.0001 17.4831 21.1142C18.3878 20.2283 18.4803 18.7751 18.6654 15.8686L18.9321 11.6807C19.0326 10.1037 19.0828 9.31524 18.6289 8.81558C18.1751 8.31592 17.4087 8.31592 15.876 8.31592H8.12404C6.59127 8.31592 5.82488 8.31592 5.37105 8.81558C4.91722 9.31524 4.96744 10.1037 5.06788 11.6807L5.33459 15.8686C5.5197 18.7751 5.61225 20.2283 6.51689 21.1142C7.42153 22.0001 8.81289 22.0001 11.5956 22.0001ZM10.2463 12.1886C10.2051 11.7548 9.83753 11.4382 9.42537 11.4816C9.01321 11.525 8.71251 11.9119 8.75372 12.3457L9.25372 17.6089C9.29494 18.0427 9.66247 18.3593 10.0746 18.3159C10.4868 18.2725 10.7875 17.8856 10.7463 17.4518L10.2463 12.1886ZM14.5746 11.4816C14.9868 11.525 15.2875 11.9119 15.2463 12.3457L14.7463 17.6089C14.7051 18.0427 14.3375 18.3593 13.9254 18.3159C13.5132 18.2725 13.2125 17.8856 13.2537 17.4518L13.7537 12.1886C13.7949 11.7548 14.1625 11.4382 14.5746 11.4816Z"" fill=""currentcolor""></path> </g></svg>
                ", w, h));
            };
        }

        public static RenderFragment ReadingBookIcon(int w, int h)
        {
            return (builder) =>
            {
                builder.AddMarkupContent(0, string.Format(@"
       	           <svg width=""{0}"" height=""{1}"" viewBox=""0 0 512 512""  fill=""currentcolor""><g id=""SVGRepo_bgCarrier"" stroke-width=""0""></g><g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""></g><g id=""SVGRepo_iconCarrier""><path fill=""currentcolor"" d=""M102.53 26.063l90 345.75 289.22 23.25-90.03-345.72-289.19-23.28zm-18.968 1.406c-30.44 11.894-55.62 53.07-49.687 75.28l3.25 11.813c.654-1.722 1.345-3.44 2.063-5.157C49.102 85.688 65.734 62.636 89.56 50.5l-6-23.03zM94.44 69.187c-16.66 10.016-29.916 28.1-38 47.437-5.2 12.44-8 25.417-8.75 36.25v.03L112.56 388.5c.305-.572.593-1.148.907-1.72 10.585-19.223 27.804-37.623 51.06-48.405L94.438 69.187zM154 107.968l239.78 16.188-1.28 18.625-239.75-16.155L154 107.97zm46.03 34.407l5.657 8.875 14.188 22.313 39.03-15.25 7.595-2.938 3.97 7.094 16.28 29.124 4.313 7.72-7.438 4.717c-10.267 6.524-17.392 12.284-21.75 16.782-3.03 3.13-4.247 5.232-4.906 6.594 1.38.303 3.433.577 6.624.28 18.268-1.69 56.285-19.964 79-61.592l5.47-10.03 8.748 7.374 46 38.812 11.532 9.72-13.844 6-33.28 14.374c5.447 4.925 11.436 5.916 18.436 5.406 9.95-.724 21.427-6.07 29.125-11.063l10.158 15.657c-9.41 6.1-22.867 12.934-37.938 14.03-15.07 1.098-32.27-5.296-42.594-23.155l-5.25-9.095 9.625-4.156 30.44-13.157-26.033-22c-25.716 40.294-62.68 59.168-87.843 61.5-6.78.628-12.945.26-18.594-2.688-5.65-2.95-9.984-10.6-9-17.406.984-6.806 4.838-12.4 10.688-18.44 4.385-4.526 10.612-9.367 17.875-14.436l-8.188-14.656L219.5 193.75l-7.156 2.78-4.125-6.468L196 170.875c-6.308 7.158-9.485 14.528-9 21.406.654 9.28 7.854 21.054 30.594 33.69l-9.094 16.343c-25.688-14.273-38.877-31.016-40.125-48.72-1.248-17.703 9.393-33.013 23.5-44.562l8.156-6.655zm-5.968 118.188l239.782 16.156-1.25 18.655-239.78-16.188 1.25-18.625zm-24.75 96.25c-17.637 9.072-31.065 23.708-39.468 38.968-4.49 8.153-7.307 16.452-8.72 23.876l11.626 42.156 1.688.157c-3.824-27.514 11.358-60.383 41.187-80.97l-6.313-24.188zm26.22 34c-32.403 17.28-46.273 52.303-41.657 72.78l289.78 24.532c-5.298-7.743-8.625-17.827-8.592-28.313l-22.47-9.03 46.626-7.313-13.69-13.064c5.552-6.838 13.54-12.915 24.47-17.53l-274.47-22.063z""></path></g></svg>
                ", w, h));
            };
        }

        public static RenderFragment PhoneIcon(int w, int h)
        {
            return (builder) =>
            {
                builder.AddMarkupContent(0, string.Format(@"
       	              <svg width=""{0}"" height=""{1}"" viewBox=""0 0 20 20"" version=""1.1""  fill=""currentcolor""><g id=""SVGRepo_bgCarrier"" stroke-width=""0""></g><g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""></g><g id=""SVGRepo_iconCarrier""> <title>call [#191]</title> <desc>Created with Sketch.</desc> <defs> </defs> <g id=""Page-1"" stroke=""none"" stroke-width=""1"" fill=""none"" fill-rule=""evenodd""> <g id=""Dribbble-Light-Preview"" transform=""translate(-140.000000, -7319.000000)"" fill=""#00e2e6""> <g id=""icons"" transform=""translate(56.000000, 160.000000)""> <path d=""M94,7167 L94,7169 L96,7169 C96,7167.895 95.105,7167 94,7167 M94,7163 L94,7165 C96.206,7165 98,7166.794 98,7169 L100,7169 C100,7165.686 97.314,7163 94,7163 M94,7159 L94,7161 C98.411,7161 102,7164.589 102,7169 L104,7169 C104,7163.477 99.523,7159 94,7159 M98.652,7177.234 C98.641,7177.265 98.64,7177.27 98.652,7177.234 M98.117,7174.578 C97.422,7174.204 96.719,7173.778 95.992,7173.481 C94.587,7172.908 94.682,7174.602 93.679,7175.151 C93.027,7175.508 92.107,7174.861 91.538,7174.503 C90.544,7173.877 89.663,7173.053 88.931,7172.1 C88.556,7171.613 87.728,7170.697 87.83,7170.014 C87.992,7168.93 89.274,7168.876 88.907,7167.55 C88.711,7166.84 88.36,7166.141 88.097,7165.457 C87.745,7164.54 87.6,7163.953 86.573,7164.003 C85.831,7164.039 85.339,7164.356 84.883,7164.951 C83.649,7166.558 83.835,7168.725 84.664,7170.488 C85.838,7172.983 87.85,7175.335 89.999,7176.855 C91.461,7177.889 93.387,7178.828 95.157,7178.987 C96.453,7179.104 98.266,7178.403 98.73,7176.996 C98.698,7177.094 98.667,7177.189 98.652,7177.234 C98.663,7177.199 98.687,7177.128 98.73,7176.996 C98.777,7176.854 98.8,7176.783 98.811,7176.751 C98.797,7176.793 98.765,7176.891 98.731,7176.993 C99.139,7175.753 99.189,7175.155 98.117,7174.578 M98.811,7176.751 C98.819,7176.727 98.819,7176.725 98.811,7176.751"" id=""call-[#191]""> </path> </g> </g> </g> </g>
                    </svg>
                ", w, h));
            };
        }

        public static RenderFragment AppLogo(int w, int h)
        {
            return (builder) =>
            {
                builder.AddMarkupContent(0, string.Format(@"
       	           <svg  version=""1.0"" width=""{0}"" height=""{1}"" viewBox=""0 0 133.000000 114.000000"" preserveAspectRatio=""xMidYMid meet"">
                        <metadata>
                        Created by potrace 1.10, written by Peter Selinger 2001-2011
                        </metadata>
                        <g transform=""translate(0.000000,114.000000) scale(0.100000,-0.100000)"" fill=""currentcolor"" stroke=""none"">
                        <path d=""M549 892 c-92 -53 -167 -101 -168 -105 -1 -5 55 -42 125 -82 l127 -73 86 50 c47 28 106 63 131 78 l46 27 46 -26 46 -27 -134 -76 -135 -76 45 -26 46 -27 152 89 c200 117 200 116 48 205 l-110 66 -129 -74 c-71 -41 -133 -75 -139 -75 -5 0 -29 11 -52 24 l-41 23 53 29 c150 81 218 119 218 124 0 4 -64 37 -90 47 -3 1 -80 -42 -171 -95z m-22 -81 c-9 -24 -7 -34 7 -56 l18 -28 -43 24 c-23 13 -44 29 -46 34 -1 6 14 20 35 31 20 12 38 22 39 23 1 1 -4 -12 -10 -28z m533 -76 c0 -14 -37 -45 -53 -45 -5 0 -7 14 -3 32 4 22 1 37 -11 51 -17 19 -16 18 25 -2 23 -12 42 -28 42 -36z""/>
                        <path d=""M320 507 c0 -204 0 -205 24 -220 21 -14 26 -14 45 -1 20 14 21 24 21 144 l0 129 45 -27 44 -27 1 -156 c0 -155 0 -156 24 -167 20 -9 29 -8 46 6 20 16 21 25 18 140 -2 67 0 122 5 122 4 0 25 -11 47 -25 l40 -25 0 -155 c0 -146 1 -155 21 -165 15 -9 25 -8 41 2 19 12 20 24 20 193 l1 180 -174 100 c-96 55 -195 113 -221 128 l-48 28 0 -204z m84 68 c-15 -14 -31 -22 -36 -19 -7 4 -6 50 1 72 1 1 15 -5 31 -13 l30 -16 -26 -24z m165 -56 l34 -20 -29 -30 -29 -30 -6 33 c-4 18 -10 41 -14 51 -9 22 2 22 44 -4z""/>
                        <path d=""M960 516 l-105 -62 -3 -153 c-2 -121 0 -152 10 -148 7 3 67 37 133 75 107 62 120 73 120 97 0 17 -8 33 -20 41 -18 12 -27 9 -83 -26 -35 -22 -65 -40 -67 -40 -3 0 -5 24 -5 53 l0 52 90 49 c76 41 90 53 90 74 0 24 -25 52 -45 51 -5 0 -57 -29 -115 -63z m-17 -268 c-31 -35 -54 -15 -45 39 l4 22 29 -21 c27 -20 28 -23 12 -40z""/>
                        </g>
                  </svg>
                ", w, h));
            };
        }

    }
}
