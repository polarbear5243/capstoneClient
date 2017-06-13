S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 14124
Date: 2017-06-13 13:46:07+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 14124, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x0000372c
r2   = 0x00000006, r3   = 0xb40534c0
r4   = 0x00000002, r5   = 0xb4053000
r6   = 0xb674d09c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0xb8d92e20
r10  = 0xbee65498, fp   = 0x00000004
ip   = 0x00000000, sp   = 0xbee65004
lr   = 0xb6643f18, pc   = 0xb6642b84
cpsr = 0x200d0010

Memory Information
MemTotal:   987012 KB
MemFree:    115956 KB
Buffers:     46824 KB
Cached:     228448 KB
VmPeak:      98736 KB
VmSize:      98732 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19640 KB
VmRSS:       19640 KB
VmData:      30212 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35776 KB
VmPTE:          74 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 14124 TID = 14124
14124 14128 14151 14155 

Maps Information
b130b000 b1313000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1325000 b1b24000 rw-p [stack:14155]
b1b24000 b1b25000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1b35000 b1b49000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1b5d000 b1b5e000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1b6e000 b1b71000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1b82000 b1b83000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1b93000 b1b95000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1ba5000 b1ba7000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1bb7000 b1bc7000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1bd7000 b1be3000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1bf5000 b23f4000 rw-p [stack:14151]
b2725000 b272c000 r-xp /usr/lib/libefl-extension.so.0.1.0
b273f000 b2745000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2755000 b2786000 r-xp /opt/usr/apps/org.example.client/bin/client
b28df000 b29c2000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b29f9000 b2a21000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a33000 b3232000 rw-p [stack:14128]
b3232000 b3234000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3244000 b324e000 r-xp /lib/libnss_files-2.20-2014.11.so
b325f000 b3268000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3279000 b328a000 r-xp /lib/libnsl-2.20-2014.11.so
b329d000 b32a3000 r-xp /lib/libnss_compat-2.20-2014.11.so
b32b4000 b32b5000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b32dd000 b32e4000 r-xp /usr/lib/libminizip.so.1.0.0
b32f4000 b32f9000 r-xp /usr/lib/libstorage.so.0.1
b3309000 b3368000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b337e000 b3392000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b33a2000 b33e6000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b33f6000 b33fe000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b340e000 b343e000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3451000 b350a000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b351e000 b3571000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3582000 b359d000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b35ad000 b366e000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3681000 b3691000 r-xp /usr/lib/libefl-assist.so.0.1.0
b36a1000 b36ae000 r-xp /usr/lib/libmdm-common.so.1.0.98
b36bf000 b36c6000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b36d6000 b3717000 r-xp /usr/lib/libmdm.so.1.2.12
b3727000 b372f000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b373e000 b374e000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b376f000 b37cf000 r-xp /usr/lib/libasound.so.2.0.0
b37e1000 b37e4000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b37f4000 b37f7000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3807000 b380c000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b381c000 b381d000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b382d000 b3838000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b384c000 b3853000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3863000 b3869000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3879000 b387e000 r-xp /usr/lib/libmmfsession.so.0.0.1
b388e000 b38a9000 r-xp /usr/lib/libmmfsound.so.0.1.0
b38b9000 b38c0000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b38d0000 b38d3000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b38e4000 b3912000 r-xp /usr/lib/libidn.so.11.5.44
b3922000 b3938000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3949000 b3953000 r-xp /usr/lib/libcares.so.2.1.0
b3963000 b396d000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b397d000 b397f000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b398f000 b3990000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b39a0000 b39a4000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b39b5000 b39dd000 r-xp /usr/lib/libui-extension.so.0.1.0
b39ee000 b3a17000 r-xp /usr/lib/libturbojpeg.so
b3a37000 b3a3d000 r-xp /usr/lib/libgif.so.4.1.6
b3a4d000 b3a93000 r-xp /usr/lib/libcurl.so.4.3.0
b3aa4000 b3ac5000 r-xp /usr/lib/libexif.so.12.3.3
b3ae0000 b3af5000 r-xp /usr/lib/libtts.so
b3b06000 b3b0e000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b1e000 b3be4000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c04000 b3cfc000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d1b000 b3de9000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e00000 b3e02000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e12000 b3e18000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e28000 b3e4b000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3e5c000 b3e5e000 r-xp /usr/lib/libappsvc.so.0.1.0
b3e6e000 b3e70000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3e81000 b3e86000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3e9d000 b3e9f000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3eaf000 b3eb6000 r-xp /usr/lib/libsensord-share.so
b3ec6000 b3ede000 r-xp /usr/lib/libsensor.so.1.1.0
b3eef000 b3ef2000 r-xp /usr/lib/libXv.so.1.0.0
b3f02000 b3f07000 r-xp /usr/lib/libutilX.so.1.1.0
b3f17000 b3f1c000 r-xp /usr/lib/libappcore-common.so.1.1
b3f2c000 b3f33000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3f46000 b3f4a000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3f5b000 b4039000 r-xp /usr/lib/libCOREGL.so.4.0
b4059000 b405c000 r-xp /usr/lib/libuuid.so.1.3.0
b406c000 b4083000 r-xp /usr/lib/libblkid.so.1.1.0
b4094000 b4096000 r-xp /usr/lib/libXau.so.6.0.0
b40a6000 b40ed000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b40ff000 b4105000 r-xp /usr/lib/libjson-c.so.2.0.1
b4116000 b411a000 r-xp /usr/lib/libogg.so.0.7.1
b412a000 b414c000 r-xp /usr/lib/libvorbis.so.0.4.3
b415c000 b4240000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b425c000 b425f000 r-xp /usr/lib/libEGL.so.1.4
b4270000 b4276000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4286000 b4288000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4298000 b42a5000 r-xp /usr/lib/libGLESv2.so.2.0
b42b6000 b4318000 r-xp /usr/lib/libpixman-1.so.0.28.2
b432d000 b4345000 r-xp /usr/lib/libmount.so.1.1.0
b4357000 b436b000 r-xp /usr/lib/libxcb.so.1.1.0
b437b000 b4382000 r-xp /lib/libcrypt-2.20-2014.11.so
b43ba000 b43bc000 r-xp /usr/lib/libiri.so
b43cc000 b43d7000 r-xp /usr/lib/libgpg-error.so.0.15.0
b43e8000 b441e000 r-xp /usr/lib/libpulse.so.0.16.2
b442f000 b4472000 r-xp /usr/lib/libsndfile.so.1.0.25
b4487000 b449c000 r-xp /lib/libexpat.so.1.5.2
b44ae000 b456c000 r-xp /usr/lib/libcairo.so.2.11200.14
b4580000 b4588000 r-xp /usr/lib/libdrm.so.2.4.0
b4598000 b459b000 r-xp /usr/lib/libdri2.so.0.0.0
b45ab000 b45f9000 r-xp /usr/lib/libssl.so.1.0.0
b460e000 b461a000 r-xp /usr/lib/libeeze.so.1.13.0
b462b000 b4634000 r-xp /usr/lib/libethumb.so.1.13.0
b4644000 b4647000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4657000 b480e000 r-xp /usr/lib/libcrypto.so.1.0.0
b55f9000 b5602000 r-xp /usr/lib/libXi.so.6.1.0
b5612000 b5614000 r-xp /usr/lib/libXgesture.so.7.0.0
b5624000 b5628000 r-xp /usr/lib/libXtst.so.6.1.0
b5638000 b563e000 r-xp /usr/lib/libXrender.so.1.3.0
b564e000 b5654000 r-xp /usr/lib/libXrandr.so.2.2.0
b5664000 b5666000 r-xp /usr/lib/libXinerama.so.1.0.0
b5677000 b567a000 r-xp /usr/lib/libXfixes.so.3.1.0
b568a000 b5695000 r-xp /usr/lib/libXext.so.6.4.0
b56a5000 b56a7000 r-xp /usr/lib/libXdamage.so.1.1.0
b56b7000 b56b9000 r-xp /usr/lib/libXcomposite.so.1.0.0
b56c9000 b57ab000 r-xp /usr/lib/libX11.so.6.3.0
b57bf000 b57c6000 r-xp /usr/lib/libXcursor.so.1.0.2
b57d6000 b57ee000 r-xp /usr/lib/libudev.so.1.6.0
b57f0000 b57f3000 r-xp /lib/libattr.so.1.1.0
b5803000 b5823000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5824000 b5829000 r-xp /usr/lib/libffi.so.6.0.2
b583a000 b5852000 r-xp /lib/libz.so.1.2.8
b5862000 b5864000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5874000 b5949000 r-xp /usr/lib/libxml2.so.2.9.2
b595e000 b59f9000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a15000 b5a18000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a28000 b5a41000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a52000 b5a63000 r-xp /lib/libresolv-2.20-2014.11.so
b5a77000 b5af1000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b06000 b5b08000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b18000 b5b1f000 r-xp /usr/lib/libembryo.so.1.13.0
b5b2f000 b5b39000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5b4a000 b5b62000 r-xp /usr/lib/libpng12.so.0.50.0
b5b73000 b5b96000 r-xp /usr/lib/libjpeg.so.8.0.2
b5bb7000 b5bcb000 r-xp /usr/lib/libector.so.1.13.0
b5bdc000 b5bf4000 r-xp /usr/lib/liblua-5.1.so
b5c05000 b5c5c000 r-xp /usr/lib/libfreetype.so.6.11.3
b5c70000 b5c98000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5ca9000 b5cbc000 r-xp /usr/lib/libfribidi.so.0.3.1
b5ccd000 b5d07000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d18000 b5d26000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d36000 b5d3e000 r-xp /usr/lib/libtbm.so.1.0.0
b5d4e000 b5d5b000 r-xp /usr/lib/libeio.so.1.13.0
b5d6b000 b5d6d000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5d7d000 b5d82000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5d92000 b5da9000 r-xp /usr/lib/libefreet.so.1.13.0
b5dbb000 b5ddb000 r-xp /usr/lib/libeldbus.so.1.13.0
b5deb000 b5e0b000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e0d000 b5e13000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e23000 b5e34000 r-xp /usr/lib/libemotion.so.1.13.0
b5e45000 b5e4c000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e5c000 b5e6b000 r-xp /usr/lib/libeo.so.1.13.0
b5e7c000 b5e8e000 r-xp /usr/lib/libecore_input.so.1.13.0
b5e9f000 b5ea4000 r-xp /usr/lib/libecore_file.so.1.13.0
b5eb4000 b5ecd000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5edd000 b5efa000 r-xp /usr/lib/libeet.so.1.13.0
b5f13000 b5f5b000 r-xp /usr/lib/libeina.so.1.13.0
b5f6c000 b5f7c000 r-xp /usr/lib/libefl.so.1.13.0
b5f8d000 b6072000 r-xp /usr/lib/libicuuc.so.51.1
b608f000 b61cf000 r-xp /usr/lib/libicui18n.so.51.1
b61e6000 b621e000 r-xp /usr/lib/libecore_x.so.1.13.0
b6230000 b6233000 r-xp /lib/libcap.so.2.21
b6243000 b626c000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b627d000 b6284000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6296000 b62cd000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b62de000 b63c9000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b63dc000 b6455000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6467000 b646c000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b647c000 b6486000 r-xp /usr/lib/libvconf.so.0.2.45
b6496000 b6498000 r-xp /usr/lib/libvasum.so.0.3.1
b64a8000 b64aa000 r-xp /usr/lib/libttrace.so.1.1
b64ba000 b64bd000 r-xp /usr/lib/libiniparser.so.0
b64cd000 b64f3000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6503000 b6508000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6519000 b6530000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6541000 b65ac000 r-xp /lib/libm-2.20-2014.11.so
b65bd000 b65c3000 r-xp /lib/librt-2.20-2014.11.so
b65d4000 b65e1000 r-xp /usr/lib/libunwind.so.8.0.1
b6617000 b673b000 r-xp /lib/libc-2.20-2014.11.so
b6750000 b6769000 r-xp /lib/libgcc_s-4.9.so.1
b6779000 b685b000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b686c000 b6896000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68a7000 b68e3000 r-xp /usr/lib/libsystemd.so.0.4.0
b68e5000 b6968000 r-xp /usr/lib/libedje.so.1.13.0
b697b000 b6999000 r-xp /usr/lib/libecore.so.1.13.0
b69b9000 b6b40000 r-xp /usr/lib/libevas.so.1.13.0
b6b75000 b6b89000 r-xp /lib/libpthread-2.20-2014.11.so
b6b9d000 b6dd1000 r-xp /usr/lib/libelementary.so.1.13.0
b6e00000 b6e04000 r-xp /usr/lib/libsmack.so.1.0.0
b6e14000 b6e1b000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e2b000 b6e2d000 r-xp /usr/lib/libdlog.so.0.0.0
b6e3d000 b6e40000 r-xp /usr/lib/libbundle.so.0.1.22
b6e50000 b6e52000 r-xp /lib/libdl-2.20-2014.11.so
b6e63000 b6e7b000 r-xp /usr/lib/libaul.so.0.1.0
b6e8f000 b6e94000 r-xp /usr/lib/libappcore-efl.so.1.1
b6ea5000 b6eb2000 r-xp /usr/lib/liblptcp.so
b6ec4000 b6ec8000 r-xp /usr/lib/libsys-assert.so
b6ed9000 b6ef9000 r-xp /lib/ld-2.20-2014.11.so
b6f0a000 b6f0f000 r-xp /usr/bin/launchpad-loader
b8d2d000 b8f72000 rw-p [heap]
bee45000 bee66000 rw-p [stack]
End of Maps Information

Callstack Information (PID:14124)
Call Stack Count: 1
 0: gsignal + 0x34 (0xb6642b84) [/lib/libc.so.6] + 0x2bb84
End of Call Stack

Package Information
Package Name: org.example.client
Package ID : org.example.client
Version: 1.0.0
Package Type: tpk
App Name: client
App ID: org.example.client
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
pp( 1175): (733) > Finished invoking application event listener for com.samsung.task-mgr, 13467.
06-13 13:46:02.219+0900 E/EFL     (13467): ecore_x<13467> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=16148436
06-13 13:46:02.219+0900 E/TASK_MGR_LITE(13467): recent_app_viewer.c: on_item_mouse_move(863) > mouse hasn't been pressed!
06-13 13:46:02.299+0900 E/EFL     (13467): ecore_x<13467> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=16148513
06-13 13:46:02.299+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
06-13 13:46:02.309+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
06-13 13:46:02.309+0900 W/AUL     (13467): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
06-13 13:46:02.309+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 0
06-13 13:46:02.309+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 13467
06-13 13:46:02.319+0900 E/RESOURCED(  667): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 6
06-13 13:46:02.319+0900 E/RESOURCED(  667): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 13:46:02.319+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
06-13 13:46:02.329+0900 W/AUL_PAD ( 1377): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-13 13:46:02.329+0900 W/AUL_PAD ( 1377): launchpad.c: __send_result_to_caller(267) > Check app launching
06-13 13:46:02.329+0900 I/UXT     (14075): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-13 13:46:02.339+0900 I/abc     (14057): abc
06-13 13:46:02.339+0900 I/CAPI_APPFW_APPLICATION(14057): app_main.c: ui_app_main(789) > app_efl_main
06-13 13:46:02.339+0900 I/CAPI_APPFW_APPLICATION(14057): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-13 13:46:02.370+0900 E/TBM     (14057): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-13 13:46:02.380+0900 E/TBM     (14075): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-13 13:46:02.380+0900 I/MALI    (14075): egl_platform_x11.c: __egl_platform_initialize(242) > [EGL-X11] PID=14075   open drm_fd=30 
06-13 13:46:02.430+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 14057, appid: org.example.client
06-13 13:46:02.430+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-13 13:46:02.430+0900 W/AUL     (13467): launch.c: app_request_to_launchpad(425) > request cmd(0) result(14057)
06-13 13:46:02.550+0900 E/EFL     (14075): edje<14075> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 13:46:02.550+0900 E/EFL     (14075): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 13:46:02.550+0900 E/EFL     (14075): edje<14075> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 13:46:02.550+0900 E/EFL     (14075): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 13:46:02.550+0900 E/EFL     (14075): edje<14075> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 13:46:02.550+0900 E/EFL     (14075): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 13:46:02.570+0900 W/CRASH_MANAGER(14044): worker.c: worker_job(1199) > 0614057636c691497329162
06-13 13:46:03.461+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 14057 pgid = 14057
06-13 13:46:03.461+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(143) > dead_pid(14057)
06-13 13:46:03.461+0900 E/Tizen::App( 1175): (703) > Cannot acquire app for 14057.
06-13 13:46:03.461+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1409
06-13 13:46:03.491+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-13 13:46:03.491+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-13 13:46:03.491+0900 E/AUL_PAD ( 1377): launchpad.c: main(698) > error reading sigchld info
06-13 13:46:03.501+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 14057
06-13 13:46:03.501+0900 I/Tizen::App( 1175): (753) > [E_OBJ_NOT_FOUND] Cannot acquire app from pid 14057.
06-13 13:46:03.501+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 14057
06-13 13:46:03.501+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 14057
06-13 13:46:03.501+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1410
06-13 13:46:03.651+0900 E/TASK_MGR_LITE(13467): recent_app_viewer.c: on_item_mouse_move(863) > mouse hasn't been pressed!
06-13 13:46:03.651+0900 E/EFL     (13467): ecore_x<13467> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=16149863
06-13 13:46:03.771+0900 E/EFL     (13467): ecore_x<13467> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=16149985
06-13 13:46:04.311+0900 I/UXT     (14124): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-13 13:46:04.311+0900 E/EFL     (13467): ecore_x<13467> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=16150521
06-13 13:46:04.452+0900 E/EFL     (13467): ecore_x<13467> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=16150665
06-13 13:46:04.592+0900 E/EFL     (13467): ecore_x<13467> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=16150799
06-13 13:46:04.702+0900 E/EFL     (13467): ecore_x<13467> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=16150909
06-13 13:46:05.022+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 22
06-13 13:46:05.022+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(1201) > app status : 5
06-13 13:46:05.022+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.task-mgr(13467)
06-13 13:46:05.022+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 13467, appid: com.samsung.task-mgr, status: bg
06-13 13:46:05.022+0900 I/CAPI_APPFW_APPLICATION(13467): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-13 13:46:05.022+0900 W/TASK_MGR_LITE(13467): task-mgr-lite.c: _pause_app(406) > 
06-13 13:46:05.022+0900 I/CAPI_APPFW_APPLICATION(13467): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
06-13 13:46:05.032+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
06-13 13:46:05.032+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 13260
06-13 13:46:05.032+0900 W/AUL     (13467): launch.c: app_request_to_launchpad(396) > request cmd(4) to(13260)
06-13 13:46:05.032+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 4
06-13 13:46:05.032+0900 I/APP_CORE(13260): appcore-efl.c: __do_app(514) > [APP 13260] Event: TERMINATE State: PAUSED
06-13 13:46:05.032+0900 W/AUL_AMD (  607): amd_launch.c: __reply_handler(1083) > listen fd(32) , send fd(31), pid(13260), cmd(4)
06-13 13:46:05.032+0900 W/AUL     (13467): launch.c: app_request_to_launchpad(425) > request cmd(4) result(0)
06-13 13:46:05.032+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 22
06-13 13:46:05.032+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(1201) > app status : 5
06-13 13:46:05.032+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 22
06-13 13:46:05.032+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(1201) > app status : 5
06-13 13:46:05.042+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
06-13 13:46:05.042+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 10998
06-13 13:46:05.042+0900 W/AUL     (13467): launch.c: app_request_to_launchpad(396) > request cmd(4) to(10998)
06-13 13:46:05.042+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 4
06-13 13:46:05.052+0900 W/AUL_AMD (  607): amd_launch.c: __reply_handler(1083) > listen fd(32) , send fd(31), pid(10998), cmd(4)
06-13 13:46:05.052+0900 W/AUL     (13467): launch.c: app_request_to_launchpad(425) > request cmd(4) result(0)
06-13 13:46:05.052+0900 I/TIZEN_N_EFL_UTIL_WINDOW(13260): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 14
06-13 13:46:05.052+0900 E/APP_CORE(13260): appcore-efl.c: _capture_and_make_file(1619) > win[7600002] widget[720] height[1280]
06-13 13:46:05.052+0900 I/APP_CORE(10998): appcore-efl.c: __do_app(514) > [APP 10998] Event: TERMINATE State: PAUSED
06-13 13:46:05.052+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 33
06-13 13:46:05.052+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 22
06-13 13:46:05.052+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(1201) > app status : 5
06-13 13:46:05.052+0900 E/APP_CORE(13260): appcore-efl.c: _capture_and_make_file(1622) > cannot a capture file for the package of [org.example.applicationlayoutsamples]
06-13 13:46:05.052+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
06-13 13:46:05.052+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 6432
06-13 13:46:05.052+0900 W/AUL     (13467): launch.c: app_request_to_launchpad(396) > request cmd(4) to(6432)
06-13 13:46:05.052+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 4
06-13 13:46:05.052+0900 I/CAPI_APPFW_APPLICATION(13260): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
06-13 13:46:05.062+0900 I/APP_CORE( 6432): appcore-efl.c: __do_app(514) > [APP 6432] Event: TERMINATE State: PAUSED
06-13 13:46:05.062+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 22
06-13 13:46:05.062+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(1201) > app status : 5
06-13 13:46:05.062+0900 W/AUL_AMD (  607): amd_launch.c: __reply_handler(1083) > listen fd(32) , send fd(31), pid(6432), cmd(4)
06-13 13:46:05.062+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 22
06-13 13:46:05.062+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(1201) > app status : 5
06-13 13:46:05.072+0900 W/AUL     (13467): launch.c: app_request_to_launchpad(425) > request cmd(4) result(0)
06-13 13:46:05.082+0900 I/TIZEN_N_EFL_UTIL_WINDOW(10998): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 12
06-13 13:46:05.082+0900 E/APP_CORE(10998): appcore-efl.c: _capture_and_make_file(1619) > win[3200003] widget[720] height[1280]
06-13 13:46:05.092+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 33
06-13 13:46:05.092+0900 E/APP_CORE(10998): appcore-efl.c: _capture_and_make_file(1622) > cannot a capture file for the package of [com.samsung.myfile-lite]
06-13 13:46:05.092+0900 E/TASK_MGR_LITE(13467): recent_app_viewer.c: destroy_recent_app_viewer(1583) > destroy_recent_app_viewer
06-13 13:46:05.092+0900 I/CAPI_APPFW_APPLICATION(10998): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
06-13 13:46:05.092+0900 I/CAPI_CONTENT_MEDIA_CONTENT(10998): media_content.c: media_content_disconnect(940) > [32m[10998]ref count changed to: 0
06-13 13:46:05.112+0900 E/CLOUD_CONTENT_SYNC_CLIENT(10998): cs_client.c: cloud_content_sync_folder_unset_changed_cb(3749) > [0;31m* Critical * Invalid handle[0;m
06-13 13:46:05.112+0900 E/CLOUD_CONTENT_SYNC_CLIENT(10998): cs_client.c: cloud_content_sync_content_unset_changed_cb(3662) > [0;31m* Critical * Invalid handle[0;m
06-13 13:46:05.112+0900 W/MYFILES (10998): mf-cloud-service.c: mf_cloud_content_destroy_handle(61) > handle is NULL
06-13 13:46:05.112+0900 E/MYFILES (10998): mf-cloud-operation.c: mf_cloud_operation_src_list_free(147) > [31mmore is [0][0m
06-13 13:46:05.112+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 22
06-13 13:46:05.112+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(1201) > app status : 5
06-13 13:46:05.112+0900 E/EFL     (10998): <10998> e_dbus.c:640 e_dbus_shutdown() Init count not greater than 0 in shutdown.
06-13 13:46:05.122+0900 E/TASK_MGR_LITE(13467): recent_apps.c: list_destroy(376) > (NULL == list) -> list_destroy() return
06-13 13:46:05.142+0900 E/APP_CORE(13467): appcore.c: appcore_flush_memory(793) > Appcore not initialized
06-13 13:46:05.152+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 13:46:05.152+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(3)
06-13 13:46:05.162+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 13:46:05.162+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-13 13:46:05.162+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(1167)
06-13 13:46:05.162+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1167, appid: com.samsung.homescreen, status: fg
06-13 13:46:05.162+0900 E/TIZEN_N_EFL_UTIL_WINDOW( 6432): efl_util_window_dump.c: _efl_util_capture_window_get_window_buffer(526) > 
06-13 13:46:05.162+0900 E/TIZEN_N_EFL_UTIL_WINDOW( 6432):  video buffer captured successfully
06-13 13:46:05.192+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(0)
06-13 13:46:05.202+0900 I/TIZEN_N_EFL_UTIL_WINDOW( 6432): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 88
06-13 13:46:05.202+0900 E/APP_CORE( 6432): appcore-efl.c: _capture_and_make_file(1619) > win[8800003] widget[720] height[1280]
06-13 13:46:05.212+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 33
06-13 13:46:05.212+0900 E/APP_CORE( 6432): appcore-efl.c: _capture_and_make_file(1622) > cannot a capture file for the package of [com.samsung.camera-app-lite]
06-13 13:46:05.232+0900 I/CAPI_APPFW_APPLICATION( 6432): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
06-13 13:46:05.232+0900 W/CAM_APP ( 6432): CamApp.cpp: onTerminate(186) > [0;35mBEGIN[0;m
06-13 13:46:05.232+0900 W/CAM_APP ( 6432): CamControl.cpp: operator()(125) > [0;35mevent type: 3[0;m
06-13 13:46:05.232+0900 W/CAM_APP ( 6432): CamControl.cpp: __terminate(1365) > [0;35mBEGIN[0;m
06-13 13:46:05.232+0900 W/CAM_APP ( 6432): CamControl.cpp: destroyShot(390) > [0;35mBEGIN[0;m
06-13 13:46:05.232+0900 W/CAM_APP ( 6432): CamControl.cpp: destroyShot(399) > [0;35mEND[0;m
06-13 13:46:05.232+0900 W/CAM_APP ( 6432): CamControl.cpp: destroyRecord(444) > [0;35mBEGIN[0;m
06-13 13:46:05.232+0900 W/CAM_APP ( 6432): CamControl.cpp: destroyRecord(451) > [0;35mEND[0;m
06-13 13:46:05.232+0900 W/CAM_APP ( 6432): CamControl.cpp: __terminate(1386) > [0;35mEND[0;m
06-13 13:46:05.232+0900 W/CAM_APP ( 6432): CamStandbyView.cpp: operator()(267) > [0;35mevent type: 3[0;m
06-13 13:46:05.232+0900 W/CAM_APP ( 6432): CamControl.cpp: unsetFaceDetectedCallback(844) > [0;35munset face detected callback: 1[0;m
06-13 13:46:05.232+0900 W/CAM_APP ( 6432): CamView.cpp: stopSelfTerminateTimer(356) > [0;35mHIT[0;m
06-13 13:46:05.232+0900 W/CAM_APP ( 6432): CamSystemDeviceMgr.cpp: setMdnieMode(439) > [0;35mBEGIN[0;m
06-13 13:46:05.232+0900 W/CAM_APP ( 6432): CamSystemDeviceMgr.cpp: __invokeDbusMethodSync(714) > [0;35mBEGIN[0;m
06-13 13:46:05.242+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(514) > [APP 1167] Event: RESUME State: PAUSED
06-13 13:46:05.242+0900 I/CAPI_APPFW_APPLICATION( 1167): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-13 13:46:05.242+0900 E/cluster-home( 1167): homescreen.cpp: OnResume(233) >  app resume
06-13 13:46:05.242+0900 W/CAM_APP ( 6432): CamSystemDeviceMgr.cpp: __invokeDbusMethodSync(756) > [0;35mEND[0;m
06-13 13:46:05.242+0900 W/CAM_APP ( 6432): CamSystemDeviceMgr.cpp: __setEnhanceScenario(476) > [0;35mset mdnie - SCENARIO_UI [0;m
06-13 13:46:05.242+0900 W/CAM_APP ( 6432): CamSystemDeviceMgr.cpp: __invokeDbusMethodSync(714) > [0;35mBEGIN[0;m
06-13 13:46:05.252+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 13:46:05.252+0900 W/CAM_APP ( 6432): CamSystemDeviceMgr.cpp: __invokeDbusMethodSync(756) > [0;35mEND[0;m
06-13 13:46:05.252+0900 W/CAM_APP ( 6432): CamSystemDeviceMgr.cpp: setMdnieMode(443) > [0;35mEND[0;m
06-13 13:46:05.252+0900 W/CAM_APP ( 6432): CamLauncher.cpp: terminatePreloadImageViewer(242) > [0;35mBEGIN[0;m
06-13 13:46:05.252+0900 W/CAM_APP ( 6432): CamLauncher.cpp: terminatePreloadImageViewer(268) > [0;35mEND[0;m
06-13 13:46:05.252+0900 W/CAM_APP ( 6432): CamThreadMgr.cpp: joinThread(85) > [0;35mBEGIN[0;m
06-13 13:46:05.252+0900 W/CAM_APP ( 6432): CamFileRegisterMgr.cpp: __registerFileThreadCb(325) > [0;35mEnd of REGISTER_FILE thread loop[0;m
06-13 13:46:05.252+0900 W/CAM_APP ( 6432): CamFileRegisterMgr.cpp: __registerFileThreadCb(330) > [0;35mEND[0;m
06-13 13:46:05.252+0900 W/CAM_APP ( 6432): CamThreadMgr.cpp: joinThread(102) > [0;35mEND[0;m
06-13 13:46:05.252+0900 I/CAPI_CONTENT_MEDIA_CONTENT( 6432): media_content.c: media_content_disconnect(940) > [32m[6432]ref count changed to: 0
06-13 13:46:05.252+0900 W/CAM_APP ( 6432): CamThreadMgr.cpp: joinThread(85) > [0;35mBEGIN[0;m
06-13 13:46:05.252+0900 W/CAM_APP ( 6432): CamSubControlMgr.cpp: __threadCb(355) > [0;35mEnd of thread loop[0;m
06-13 13:46:05.252+0900 W/CAM_APP ( 6432): CamSubControlMgr.cpp: __threadCb(360) > [0;35mEND[0;m
06-13 13:46:05.252+0900 W/CAM_APP ( 6432): CamThreadMgr.cpp: joinThread(102) > [0;35mEND[0;m
06-13 13:46:05.252+0900 W/CAM_APP ( 6432): CamCoordRotationMgr.cpp: stop(83) > [0;35mBEGIN[0;m
06-13 13:46:05.252+0900 W/CAM_APP ( 6432): CamCoordRotationMgr.cpp: stop(86) > [0;35malready stopped. skip this[0;m
06-13 13:46:05.252+0900 W/CAM_APP ( 6432): CamSystemDeviceMgr.cpp: unlockDisplay(97) > [0;35mBEGIN[0;m
06-13 13:46:05.262+0900 W/CAM_APP ( 6432): CamSystemDeviceMgr.cpp: unlockDisplay(112) > [0;35mEND[0;m
06-13 13:46:05.262+0900 W/CAM_APP ( 6432): CamSystemDeviceMgr.cpp: unregisterEvent(416) > [0;35mBEGIN[0;m
06-13 13:46:05.262+0900 I/Tizen::System( 1175): (259) > Active app [com.samsun], current [com.samsun] 
06-13 13:46:05.262+0900 I/Tizen::System( 1175): (273) > Current App[com.samsun] is already actived.
06-13 13:46:05.272+0900 W/CAM_APP ( 6432): CamSystemDeviceMgr.cpp: unregisterEvent(434) > [0;35mEND[0;m
06-13 13:46:05.272+0900 W/CAM_APP ( 6432): CamAFMgr.cpp: stop(130) > [0;35mBEGIN[0;m
06-13 13:46:05.272+0900 W/CAM_APP ( 6432): CamAFMgr.cpp: reset(152) > [0;35mHIT[0;m
06-13 13:46:05.272+0900 W/CAM_APP ( 6432): CamDevControl.cpp: stopAutoFocusing(557) > [0;35mBEGIN[0;m
06-13 13:46:05.272+0900 E/TIZEN_N_CAMERA( 6432): camera.c: __convert_camera_error_code(231) > [camera_cancel_focusing] INVALID_STATE(0xfe6f0002) : core frameworks error code(0x80000817)
06-13 13:46:05.272+0900 E/CAM_APP ( 6432): CamDevControl.cpp: stopAutoFocusing(562) > [0;31m* Critical * camera_cancel_focusing failed - [-26279934][0;m
06-13 13:46:05.272+0900 W/CAM_APP ( 6432): CamAFMgr.cpp: stop(146) > [0;35mEND[0;m
06-13 13:46:05.272+0900 W/CAM_APP ( 6432): CamControl.cpp: destroyShot(390) > [0;35mBEGIN[0;m
06-13 13:46:05.272+0900 W/CAM_APP ( 6432): CamControl.cpp: destroyShot(399) > [0;35mEND[0;m
06-13 13:46:05.272+0900 W/CAM_APP ( 6432): CamControl.cpp: destroyRecord(444) > [0;35mBEGIN[0;m
06-13 13:46:05.272+0900 W/CAM_APP ( 6432): CamControl.cpp: destroyRecord(451) > [0;35mEND[0;m
06-13 13:46:05.282+0900 E/weather-widget( 1324): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-13 13:46:05.292+0900 E/efl-extension( 6432): efl_extension.c: eext_win_keygrab_unset(123) >   Can't unset keygrab of [XF86AudioRaiseVolume].
06-13 13:46:05.292+0900 E/efl-extension( 6432): efl_extension.c: eext_win_keygrab_unset(123) >   Can't unset keygrab of [XF86AudioLowerVolume].
06-13 13:46:05.292+0900 W/CAM_APP ( 6432): CamDevControl.cpp: destroyDevice(130) > [0;35mBEGIN[0;m
06-13 13:46:05.292+0900 W/CAM_APP ( 6432): CamSoundSessionMgr.cpp: destroySession(67) > [0;35mBEGIN[0;m
06-13 13:46:05.292+0900 I/TIZEN_N_SOUND_MANAGER( 6432): sound_manager_product.c: sound_manager_multi_session_destroy(939) > >> enter : session=0xb8dd7fd0
06-13 13:46:05.292+0900 I/TIZEN_N_SOUND_MANAGER( 6432): sound_manager_product.c: sound_manager_multi_session_destroy(1001) > << leave : already set same option(0), skip it
06-13 13:46:05.292+0900 I/TIZEN_N_SOUND_MANAGER( 6432): sound_manager_product.c: sound_manager_multi_session_destroy(1010) > << leave : session=(nil)
06-13 13:46:05.292+0900 W/CAM_APP ( 6432): CamSoundSessionMgr.cpp: destroySession(75) > [0;35mEND[0;m
06-13 13:46:05.292+0900 E/TIZEN_N_RECORDER( 6432): recorder.c: __convert_recorder_error_code(189) > [recorder_destroy] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-13 13:46:05.292+0900 W/TIZEN_N_CAMERA( 6432): camera.c: camera_destroy(984) > camera handle 0xb8dd8730
06-13 13:46:05.292+0900 I/TIZEN_N_CAMERA( 6432): camera.c: _camera_remove_cb_message(91) > start
06-13 13:46:05.292+0900 W/TIZEN_N_CAMERA( 6432): camera.c: _camera_remove_cb_message(117) > There is no remained callback
06-13 13:46:05.292+0900 I/TIZEN_N_CAMERA( 6432): camera.c: _camera_remove_cb_message(122) > done
06-13 13:46:05.292+0900 W/CAM_APP ( 6432): CamDevControl.cpp: destroyDevice(152) > [0;35mEND[0;m
06-13 13:46:05.312+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-13 13:46:05.312+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-13 13:46:05.312+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 13:46:05.312+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 13:46:05.312+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 13:46:05.312+0900 W/CAM_APP ( 6432): CamApp.cpp: onTerminate(239) > [0;35mEND[0;m
06-13 13:46:05.322+0900 I/MALI    (13467): egl_platform_x11.c: __egl_platform_terminate(358) > [EGL-X11] PID=13467   close drm_fd=30 
06-13 13:46:05.322+0900 E/weather-widget( 1324): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-13 13:46:05.342+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 13:46:05.362+0900 W/CAM_APP ( 6432): CamButton.cpp: ~CamButton(45) > [0;35mname = [Camera button], buttonMenu = [0][0;m
06-13 13:46:05.362+0900 W/CAM_APP ( 6432): CamButton.cpp: ~CamButton(45) > [0;35mname = [Camcorder button], buttonMenu = [2][0;m
06-13 13:46:05.382+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 13:46:05.382+0900 E/weather-widget( 1324): WidgetMain.cpp: ResumeWidgetInstance(585) > [0;40;31m[ResumeWidgetInstance(): 585] (widgetViewDataPtr->GetNumberOfCities() <= 0) [break][0;m
06-13 13:46:05.382+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-13 13:46:05.382+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-13 13:46:05.382+0900 W/AUL     ( 1324): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1324, appid: com.samsung.weather-m-widget, status: fg
06-13 13:46:05.443+0900 W/CAM_APP ( 6432): CamButton.cpp: ~CamButton(45) > [0;35mname = [Switch button], buttonMenu = [37][0;m
06-13 13:46:05.473+0900 W/CAM_APP ( 6432): CamButton.cpp: ~CamButton(45) > [0;35mname = [Quick setting button], buttonMenu = [7][0;m
06-13 13:46:05.473+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 13260 pgid = 13260
06-13 13:46:05.473+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(143) > dead_pid(13260)
06-13 13:46:05.473+0900 W/CAM_APP ( 6432): CamButton.cpp: ~CamButton(45) > [0;35mname = [Thumbnail button], buttonMenu = [8][0;m
06-13 13:46:05.513+0900 W/CAM_APP ( 6432): CamButton.cpp: ~CamButton(45) > [0;35mname = [Mode button], buttonMenu = [55][0;m
06-13 13:46:05.513+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-13 13:46:05.513+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-13 13:46:05.513+0900 E/AUL_PAD ( 1377): launchpad.c: main(698) > error reading sigchld info
06-13 13:46:05.513+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 13260
06-13 13:46:05.513+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 13260
06-13 13:46:05.513+0900 W/CAM_APP ( 6432): CamGuideText.cpp: clear(79) > [0;35mguide text is not displayed again until CamGuideText is re-created[0;m
06-13 13:46:05.523+0900 I/Tizen::App( 1175): (243) > App[org.example.applicationlayoutsamples] pid[13260] terminate event is forwarded
06-13 13:46:05.523+0900 I/Tizen::System( 1175): (256) > osp.accessorymanager.service provider is found.
06-13 13:46:05.523+0900 I/Tizen::System( 1175): (196) > Accessory Owner is removed [org.example.applicationlayoutsamples, 13260, ]
06-13 13:46:05.523+0900 I/Tizen::System( 1175): (256) > osp.system.service provider is found.
06-13 13:46:05.523+0900 I/Tizen::App( 1175): (506) > TerminatedApp(org.example.applicationlayoutsamples)
06-13 13:46:05.523+0900 I/Tizen::App( 1175): (512) > Not registered pid(13260)
06-13 13:46:05.523+0900 I/Tizen::System( 1175): (246) > Terminated app [org.example.applicationlayoutsamples]
06-13 13:46:05.523+0900 I/Tizen::Io( 1175): (729) > Entry not found
06-13 13:46:05.523+0900 E/EFL     ( 6432): <6432> elm_main.c:1305 elm_object_part_content_unset() safety check failed: obj == NULL
06-13 13:46:05.543+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-13 13:46:05.543+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 13:46:05.543+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1413
06-13 13:46:05.553+0900 I/Tizen::System( 1175): (157) > change brightness system value.
06-13 13:46:05.553+0900 I/Tizen::App( 1175): (782) > Finished invoking application event listener for org.example.applicationlayoutsamples, 13260.
06-13 13:46:05.563+0900 I/MALI    (10998): egl_platform_x11.c: __egl_platform_terminate(358) > [EGL-X11] PID=10998   close drm_fd=30 
06-13 13:46:05.583+0900 I/MALI    ( 6432): egl_platform_x11.c: __egl_platform_terminate(358) > [EGL-X11] PID=6432   close drm_fd=30 
06-13 13:46:05.643+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 13467 pgid = 13467
06-13 13:46:05.643+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(143) > dead_pid(13467)
06-13 13:46:05.683+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-13 13:46:05.683+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-13 13:46:05.683+0900 E/AUL_PAD ( 1377): launchpad.c: main(698) > error reading sigchld info
06-13 13:46:05.683+0900 I/Tizen::App( 1175): (243) > App[com.samsung.task-mgr] pid[13467] terminate event is forwarded
06-13 13:46:05.683+0900 I/Tizen::System( 1175): (256) > osp.accessorymanager.service provider is found.
06-13 13:46:05.683+0900 I/Tizen::System( 1175): (196) > Accessory Owner is removed [com.samsung.task-mgr, 13467, ]
06-13 13:46:05.683+0900 I/Tizen::System( 1175): (256) > osp.system.service provider is found.
06-13 13:46:05.683+0900 I/Tizen::App( 1175): (506) > TerminatedApp(com.samsung.task-mgr)
06-13 13:46:05.683+0900 I/Tizen::App( 1175): (512) > Not registered pid(13467)
06-13 13:46:05.683+0900 I/Tizen::System( 1175): (246) > Terminated app [com.samsung.task-mgr]
06-13 13:46:05.683+0900 I/Tizen::Io( 1175): (729) > Entry not found
06-13 13:46:05.683+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 13467
06-13 13:46:05.693+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 13467
06-13 13:46:05.693+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 13467
06-13 13:46:05.703+0900 I/Tizen::System( 1175): (157) > change brightness system value.
06-13 13:46:05.703+0900 I/Tizen::App( 1175): (782) > Finished invoking application event listener for com.samsung.task-mgr, 13467.
06-13 13:46:05.823+0900 W/CAM_APP ( 6432): main.cpp: main(32) > [0;35mEND[0;m
06-13 13:46:05.873+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 6432 pgid = 6432
06-13 13:46:05.873+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(143) > dead_pid(6432)
06-13 13:46:05.913+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-13 13:46:05.913+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-13 13:46:05.913+0900 E/AUL_PAD ( 1377): launchpad.c: main(698) > error reading sigchld info
06-13 13:46:05.913+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 6432
06-13 13:46:05.913+0900 I/Tizen::App( 1175): (243) > App[com.samsung.camera-app-lite] pid[6432] terminate event is forwarded
06-13 13:46:05.913+0900 I/Tizen::System( 1175): (256) > osp.accessorymanager.service provider is found.
06-13 13:46:05.913+0900 I/Tizen::System( 1175): (196) > Accessory Owner is removed [com.samsung.camera-app-lite, 6432, ]
06-13 13:46:05.913+0900 I/Tizen::System( 1175): (256) > osp.system.service provider is found.
06-13 13:46:05.913+0900 I/Tizen::App( 1175): (506) > TerminatedApp(com.samsung.camera-app-lite)
06-13 13:46:05.913+0900 I/Tizen::App( 1175): (512) > Not registered pid(6432)
06-13 13:46:05.913+0900 I/Tizen::System( 1175): (246) > Terminated app [com.samsung.camera-app-lite]
06-13 13:46:05.913+0900 I/Tizen::Io( 1175): (729) > Entry not found
06-13 13:46:05.923+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 6432
06-13 13:46:05.923+0900 W/CAM_SERVICE( 1343): CamService.cpp: __launchCameraApp(86) > [33mBEGIN[0m
06-13 13:46:05.923+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
06-13 13:46:05.933+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
06-13 13:46:05.933+0900 W/AUL     ( 1343): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.camera-app-lite)
06-13 13:46:05.933+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1415
06-13 13:46:05.933+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 0
06-13 13:46:05.933+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 1343
06-13 13:46:05.933+0900 I/AUL_AMD (  607): amd_launch.c: __check_app_control_privilege(1830) > Skip the privilege check in case of preloaded apps
06-13 13:46:05.943+0900 I/Tizen::System( 1175): (157) > change brightness system value.
06-13 13:46:05.943+0900 I/Tizen::App( 1175): (782) > Finished invoking application event listener for com.samsung.camera-app-lite, 6432.
06-13 13:46:05.953+0900 E/RESOURCED(  667): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 13:46:05.953+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
06-13 13:46:05.953+0900 W/AUL_PAD ( 1377): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-13 13:46:05.953+0900 W/AUL_PAD ( 1377): launchpad.c: __send_result_to_caller(267) > Check app launching
06-13 13:46:05.963+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=16152174
06-13 13:46:06.043+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=16152251
06-13 13:46:06.043+0900 W/AUL     ( 1167): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.client)
06-13 13:46:06.103+0900 W/CAM_APP (14075): main.cpp: main(26) > [0;35mBEGIN[0;m
06-13 13:46:06.103+0900 I/CAPI_APPFW_APPLICATION(14075): app_main.c: ui_app_main(789) > app_efl_main
06-13 13:46:06.103+0900 I/CAPI_APPFW_APPLICATION(14075): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-13 13:46:06.103+0900 W/CAM_APP (14075): CamApp.cpp: onCreate(102) > [0;35mBEGIN[0;m
06-13 13:46:06.163+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 14075, appid: com.samsung.camera-app-lite
06-13 13:46:06.163+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-13 13:46:06.163+0900 W/AUL     ( 1343): launch.c: app_request_to_launchpad(425) > request cmd(0) result(14075)
06-13 13:46:06.163+0900 W/CAM_SERVICE( 1343): CamService.cpp: __launchCameraApp(119) > [33mEND[0m
06-13 13:46:06.163+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 1
06-13 13:46:06.163+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 1167
06-13 13:46:06.183+0900 E/RESOURCED(  667): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 6
06-13 13:46:06.193+0900 E/RESOURCED(  667): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 13:46:06.193+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
06-13 13:46:06.203+0900 I/CAPI_CONTENT_MEDIA_CONTENT(14075): media_content.c: media_content_connect(856) > [32m[14075]ref count : 0
06-13 13:46:06.203+0900 I/CAPI_CONTENT_MEDIA_CONTENT(14075): media_content.c: media_content_connect(888) > [32m[14075]ref count changed to: 1
06-13 13:46:06.203+0900 W/CAM_APP (14075): CamThreadMgr.cpp: createThread(47) > [0;35mBEGIN[0;m
06-13 13:46:06.203+0900 W/CAM_APP (14075): CamThreadMgr.cpp: createThread(67) > [0;35mEND[0;m
06-13 13:46:06.203+0900 W/CAM_APP (14075): CamFileRegisterMgr.cpp: __registerFileThreadCb(277) > [0;35mBEGIN[0;m
06-13 13:46:06.203+0900 W/CAM_APP (14075): CamDreamTemplateInfo.cpp: init(47) > [0;35mSTART[0;m
06-13 13:46:06.203+0900 W/CAM_APP (14075): CamDreamTemplateInfo.cpp: init(65) > [0;35mg_key_file_load_from_file failed: No such file or directory[0;m
06-13 13:46:06.213+0900 W/CAM_APP (14075): CamDreamTemplateInfo.cpp: init(76) > [0;35mload default data for dreamshot[0;m
06-13 13:46:06.213+0900 W/CAM_APP (14075): CamDreamTemplateInfo.cpp: init(90) > [0;35mEND[0;m
06-13 13:46:06.243+0900 W/CAM_APP (14075): CamSiopControlMgr.cpp: start(49) > [0;35mBEGIN[0;m
06-13 13:46:06.253+0900 W/CAM_APP (14075): CamSiopControlMgr.cpp: start(62) > [0;35mEND[0;m
06-13 13:46:07.184+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 10998 pgid = 10998
06-13 13:46:07.184+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(143) > dead_pid(10998)
06-13 13:46:07.204+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1417
06-13 13:46:07.204+0900 I/Tizen::App( 1175): (499) > LaunchedApp(com.samsung.camera-app-lite)
06-13 13:46:07.204+0900 I/Tizen::App( 1175): (733) > Finished invoking application event listener for com.samsung.camera-app-lite, 14075.
06-13 13:46:07.234+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-13 13:46:07.234+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-13 13:46:07.234+0900 E/AUL_PAD ( 1377): launchpad.c: main(698) > error reading sigchld info
06-13 13:46:07.234+0900 W/AUL_PAD ( 1377): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-13 13:46:07.234+0900 W/AUL_PAD ( 1377): launchpad.c: __send_result_to_caller(267) > Check app launching
06-13 13:46:07.234+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 10998
06-13 13:46:07.234+0900 I/Tizen::App( 1175): (243) > App[com.samsung.myfile-lite] pid[10998] terminate event is forwarded
06-13 13:46:07.234+0900 I/Tizen::System( 1175): (256) > osp.accessorymanager.service provider is found.
06-13 13:46:07.234+0900 I/Tizen::System( 1175): (196) > Accessory Owner is removed [com.samsung.myfile-lite, 10998, ]
06-13 13:46:07.234+0900 I/Tizen::System( 1175): (256) > osp.system.service provider is found.
06-13 13:46:07.234+0900 I/Tizen::App( 1175): (506) > TerminatedApp(com.samsung.myfile-lite)
06-13 13:46:07.234+0900 I/Tizen::App( 1175): (512) > Not registered pid(10998)
06-13 13:46:07.234+0900 I/Tizen::System( 1175): (246) > Terminated app [com.samsung.myfile-lite]
06-13 13:46:07.244+0900 I/Tizen::Io( 1175): (729) > Entry not found
06-13 13:46:07.244+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1418
06-13 13:46:07.254+0900 I/Tizen::System( 1175): (157) > change brightness system value.
06-13 13:46:07.254+0900 I/Tizen::App( 1175): (782) > Finished invoking application event listener for com.samsung.myfile-lite, 10998.
06-13 13:46:07.254+0900 I/abc     (14124): abc
06-13 13:46:07.254+0900 I/CAPI_APPFW_APPLICATION(14124): app_main.c: ui_app_main(789) > app_efl_main
06-13 13:46:07.254+0900 I/CAPI_APPFW_APPLICATION(14124): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-13 13:46:07.284+0900 E/TBM     (14124): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-13 13:46:07.334+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 14124, appid: org.example.client
06-13 13:46:07.334+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-13 13:46:07.344+0900 W/AUL     ( 1167): launch.c: app_request_to_launchpad(425) > request cmd(1) result(14124)
06-13 13:46:07.354+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
06-13 13:46:07.354+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 14075
06-13 13:46:07.354+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 12
06-13 13:46:07.364+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 10998
06-13 13:46:07.364+0900 W/CAM_APP (14075): CamApp.cpp: onCreate(180) > [0;35mEND[0;m
06-13 13:46:07.364+0900 I/APP_CORE(14075): appcore-efl.c: __do_app(514) > [APP 14075] Event: RESET State: CREATED
06-13 13:46:07.364+0900 I/CAPI_APPFW_APPLICATION(14075): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-13 13:46:07.364+0900 W/CAM_APP (14075): CamApp.cpp: onAppControl(244) > [0;35mBEGIN : firstLaunch - [1][0;m
06-13 13:46:07.364+0900 W/CAM_APP (14075): CamRequestParser.cpp: parse(61) > [0;35mBEGIN[0;m
06-13 13:46:07.364+0900 W/CAM_APP (14075): CamRequestParser.cpp: __parseMainData(127) > [0;35moperation - [http://tizen.org/appcontrol/operation/prelaunch][0;m
06-13 13:46:07.364+0900 W/CAM_APP (14075): CamRequestParser.cpp: parse(76) > [0;35mdonot need to parse other data[0;m
06-13 13:46:07.364+0900 W/CAM_APP (14075): CamRequestParser.cpp: parse(83) > [0;35mEND[0;m
06-13 13:46:07.364+0900 W/CAM_APP (14075): CamDevControl.cpp: createDevice(91) > [0;35mBEGIN - type : [0][0;m
06-13 13:46:07.364+0900 W/CAM_APP (14075): CamSoundSessionMgr.cpp: createSession(54) > [0;35mBEGIN[0;m
06-13 13:46:07.364+0900 I/TIZEN_N_SOUND_MANAGER(14075): sound_manager_product.c: sound_manager_multi_session_create(656) > >> enter : type=2, session=0xb8995450
06-13 13:46:07.374+0900 I/TIZEN_N_SOUND_MANAGER(14075): sound_manager_product.c: sound_manager_multi_session_create(726) > << leave : type=2, session=0xb8995450
06-13 13:46:07.374+0900 W/CAM_APP (14075): CamSoundSessionMgr.cpp: createSession(60) > [0;35mEND[0;m
06-13 13:46:07.374+0900 W/TIZEN_N_CAMERA(14075): camera.c: camera_create(879) > device name = [0]
06-13 13:46:07.454+0900 W/TIZEN_N_CAMERA(14075): camera.c: camera_create(963) > camera handle 0xb89956a8
06-13 13:46:07.454+0900 W/TIZEN_N_RECORDER(14075): recorder.c: recorder_create_videorecorder(553) > permission check done
06-13 13:46:07.454+0900 E/TIZEN_N_RECORDER(14075): recorder.c: __convert_recorder_error_code(189) > [audio-device] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-13 13:46:07.454+0900 E/TIZEN_N_RECORDER(14075): recorder.c: __convert_recorder_error_code(189) > [recorder_attr_set_audio_tuning] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-13 13:46:07.454+0900 W/CAM_APP (14075): CamDevControl.cpp: createDevice(124) > [0;35mEND[0;m
06-13 13:46:07.454+0900 W/CAM_APP (14075): CamSubControlMgr.cpp: runSubControlThread(90) > [0;35mBEGIN - controlType:[9][0;m
06-13 13:46:07.454+0900 W/CAM_APP (14075): CamSubControlMgr.cpp: runSubControlThread(101) > [0;35mcreate CONTROL_CAMERA thread[0;m
06-13 13:46:07.454+0900 W/CAM_APP (14075): CamThreadMgr.cpp: createThread(47) > [0;35mBEGIN[0;m
06-13 13:46:07.454+0900 W/CAM_APP (14075): CamThreadMgr.cpp: createThread(67) > [0;35mEND[0;m
06-13 13:46:07.454+0900 W/CAM_APP (14075): CamSubControlMgr.cpp: __threadCb(131) > [0;35mBEGIN[0;m
06-13 13:46:07.454+0900 W/CAM_APP (14075): CamSubControlMgr.cpp: __threadCb(152) > [0;35mstart thread control type - [9][0;m
06-13 13:46:07.454+0900 W/CAM_APP (14075): CamSubControlMgr.cpp: runSubControlThread(125) > [0;35mEND[0;m
06-13 13:46:07.454+0900 I/TIZEN_N_CAMERA(14075): camera_product.c: camera_preload_framework(1142) > start load plugin
06-13 13:46:07.464+0900 W/CAM_APP (14075): CamView.cpp: __initialize(67) > [0;35mBEGIN[0;m
06-13 13:46:07.464+0900 W/CAM_APP (14075): CamView.cpp: __initialize(85) > [0;35mEND[0;m
06-13 13:46:07.515+0900 W/CAM_APP (14075): CamApp.cpp: onAppControl(378) > [0;35mset _E_MOVE_PANEL_SCROLLABLE_STATE as unblocked[0;m
06-13 13:46:07.525+0900 W/CAM_APP (14075): CamSystemDeviceMgr.cpp: isIdleLocked(353) > [0;35mVCONFKEY_IDLE_LOCK_STATE state = [0][0;m
06-13 13:46:07.525+0900 W/CAM_APP (14075): CamApp.cpp: onAppControl(396) > [0;35mEND[0;m
06-13 13:46:07.525+0900 E/EFL     (14075): edje<14075> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 13:46:07.525+0900 E/EFL     (14075): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 13:46:07.525+0900 E/EFL     (14075): edje<14075> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 13:46:07.525+0900 E/EFL     (14075): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 13:46:07.525+0900 E/EFL     (14075): edje<14075> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 13:46:07.525+0900 E/EFL     (14075): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 13:46:07.525+0900 E/EFL     (14075): edje<14075> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 13:46:07.525+0900 E/EFL     (14075): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 13:46:07.525+0900 E/EFL     (14075): edje<14075> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 13:46:07.525+0900 E/EFL     (14075): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 13:46:07.525+0900 E/EFL     (14075): edje<14075> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 13:46:07.525+0900 E/EFL     (14075): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 13:46:07.525+0900 E/EFL     (14075): edje<14075> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 13:46:07.525+0900 E/EFL     (14075): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 13:46:07.525+0900 E/EFL     (14075): edje<14075> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 13:46:07.525+0900 E/EFL     (14075): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 13:46:07.685+0900 I/TIZEN_N_CAMERA(14075): camera_product.c: camera_preload_framework(1152) > done load plugin
06-13 13:46:07.685+0900 W/CAM_APP (14075): CamSubControlMgr.cpp: __threadCb(351) > [0;35mdone[0;m
06-13 13:46:08.245+0900 I/UXT     (14144): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-13 13:46:08.295+0900 E/TBM     (14144): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-13 13:46:08.295+0900 I/MALI    (14144): egl_platform_x11.c: __egl_platform_initialize(242) > [EGL-X11] PID=14144   open drm_fd=30 
06-13 13:46:08.335+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 13:46:08.335+0900 W/AUL_AMD (  607): amd_launch.c: __grab_timeout_handler(1623) > back key ungrab error
06-13 13:46:08.365+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 14124 pgid = 14124
06-13 13:46:08.365+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(143) > dead_pid(14124)
06-13 13:46:08.365+0900 E/Tizen::App( 1175): (703) > Cannot acquire app for 14124.
06-13 13:46:08.375+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1421
06-13 13:46:08.415+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-13 13:46:08.415+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-13 13:46:08.415+0900 E/AUL_PAD ( 1377): launchpad.c: main(698) > error reading sigchld info
06-13 13:46:08.415+0900 I/Tizen::App( 1175): (753) > [E_OBJ_NOT_FOUND] Cannot acquire app from pid 14124.
06-13 13:46:08.415+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 14124
06-13 13:46:08.415+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 14124
06-13 13:46:08.415+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 14124
06-13 13:46:08.425+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1422
06-13 13:46:08.455+0900 E/EFL     (14144): edje<14144> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 13:46:08.455+0900 E/EFL     (14144): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 13:46:08.455+0900 E/EFL     (14144): edje<14144> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 13:46:08.455+0900 E/EFL     (14144): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 13:46:08.455+0900 E/EFL     (14144): edje<14144> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 13:46:08.455+0900 E/EFL     (14144): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 13:46:09.216+0900 I/UXT     (14172): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-13 13:46:09.897+0900 W/CRASH_MANAGER(14044): worker.c: worker_job(1199) > 0614124636c69149732916
