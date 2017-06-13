S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 21635
Date: 2017-06-13 14:26:09+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 21635, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00005483
r2   = 0x00000006, r3   = 0xb40454c0
r4   = 0x00000002, r5   = 0xb4045000
r6   = 0xb673f09c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0xb84e5c48
r10  = 0xbe95d498, fp   = 0x00000004
ip   = 0x00000000, sp   = 0xbe95d014
lr   = 0xb6635f18, pc   = 0xb6634b84
cpsr = 0x200d0010

Memory Information
MemTotal:   987012 KB
MemFree:    145244 KB
Buffers:     67240 KB
Cached:     239108 KB
VmPeak:      90536 KB
VmSize:      90532 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19624 KB
VmRSS:       19624 KB
VmData:      22012 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35776 KB
VmPTE:          72 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 21635 TID = 21635
21635 21636 21758 

Maps Information
b1afd000 b1b05000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1b16000 b1b17000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1b27000 b1b3b000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1b4f000 b1b50000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1b60000 b1b63000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1b74000 b1b75000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1b85000 b1b87000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1b97000 b1b99000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1ba9000 b1bb9000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1bc9000 b1bd5000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1be7000 b23e6000 rw-p [stack:21758]
b2717000 b271e000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2731000 b2737000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2747000 b2778000 r-xp /opt/usr/apps/org.example.client/bin/client
b28d1000 b29b4000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b29eb000 b2a13000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a25000 b3224000 rw-p [stack:21636]
b3224000 b3226000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3236000 b3240000 r-xp /lib/libnss_files-2.20-2014.11.so
b3251000 b325a000 r-xp /lib/libnss_nis-2.20-2014.11.so
b326b000 b327c000 r-xp /lib/libnsl-2.20-2014.11.so
b328f000 b3295000 r-xp /lib/libnss_compat-2.20-2014.11.so
b32a6000 b32a7000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b32cf000 b32d6000 r-xp /usr/lib/libminizip.so.1.0.0
b32e6000 b32eb000 r-xp /usr/lib/libstorage.so.0.1
b32fb000 b335a000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3370000 b3384000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b3394000 b33d8000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b33e8000 b33f0000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3400000 b3430000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3443000 b34fc000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3510000 b3563000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3574000 b358f000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b359f000 b3660000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3673000 b3683000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3693000 b36a0000 r-xp /usr/lib/libmdm-common.so.1.0.98
b36b1000 b36b8000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b36c8000 b3709000 r-xp /usr/lib/libmdm.so.1.2.12
b3719000 b3721000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3730000 b3740000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3761000 b37c1000 r-xp /usr/lib/libasound.so.2.0.0
b37d3000 b37d6000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b37e6000 b37e9000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b37f9000 b37fe000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b380e000 b380f000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b381f000 b382a000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b383e000 b3845000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3855000 b385b000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b386b000 b3870000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3880000 b389b000 r-xp /usr/lib/libmmfsound.so.0.1.0
b38ab000 b38b2000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b38c2000 b38c5000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b38d6000 b3904000 r-xp /usr/lib/libidn.so.11.5.44
b3914000 b392a000 r-xp /usr/lib/libnghttp2.so.5.4.0
b393b000 b3945000 r-xp /usr/lib/libcares.so.2.1.0
b3955000 b395f000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b396f000 b3971000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3981000 b3982000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3992000 b3996000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b39a7000 b39cf000 r-xp /usr/lib/libui-extension.so.0.1.0
b39e0000 b3a09000 r-xp /usr/lib/libturbojpeg.so
b3a29000 b3a2f000 r-xp /usr/lib/libgif.so.4.1.6
b3a3f000 b3a85000 r-xp /usr/lib/libcurl.so.4.3.0
b3a96000 b3ab7000 r-xp /usr/lib/libexif.so.12.3.3
b3ad2000 b3ae7000 r-xp /usr/lib/libtts.so
b3af8000 b3b00000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b10000 b3bd6000 r-xp /usr/lib/libdali-core.so.0.0.0
b3bf6000 b3cee000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d0d000 b3ddb000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3df2000 b3df4000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e04000 b3e0a000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e1a000 b3e3d000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3e4e000 b3e50000 r-xp /usr/lib/libappsvc.so.0.1.0
b3e60000 b3e62000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3e73000 b3e78000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3e8f000 b3e91000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3ea1000 b3ea8000 r-xp /usr/lib/libsensord-share.so
b3eb8000 b3ed0000 r-xp /usr/lib/libsensor.so.1.1.0
b3ee1000 b3ee4000 r-xp /usr/lib/libXv.so.1.0.0
b3ef4000 b3ef9000 r-xp /usr/lib/libutilX.so.1.1.0
b3f09000 b3f0e000 r-xp /usr/lib/libappcore-common.so.1.1
b3f1e000 b3f25000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3f38000 b3f3c000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3f4d000 b402b000 r-xp /usr/lib/libCOREGL.so.4.0
b404b000 b404e000 r-xp /usr/lib/libuuid.so.1.3.0
b405e000 b4075000 r-xp /usr/lib/libblkid.so.1.1.0
b4086000 b4088000 r-xp /usr/lib/libXau.so.6.0.0
b4098000 b40df000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b40f1000 b40f7000 r-xp /usr/lib/libjson-c.so.2.0.1
b4108000 b410c000 r-xp /usr/lib/libogg.so.0.7.1
b411c000 b413e000 r-xp /usr/lib/libvorbis.so.0.4.3
b414e000 b4232000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b424e000 b4251000 r-xp /usr/lib/libEGL.so.1.4
b4262000 b4268000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4278000 b427a000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b428a000 b4297000 r-xp /usr/lib/libGLESv2.so.2.0
b42a8000 b430a000 r-xp /usr/lib/libpixman-1.so.0.28.2
b431f000 b4337000 r-xp /usr/lib/libmount.so.1.1.0
b4349000 b435d000 r-xp /usr/lib/libxcb.so.1.1.0
b436d000 b4374000 r-xp /lib/libcrypt-2.20-2014.11.so
b43ac000 b43ae000 r-xp /usr/lib/libiri.so
b43be000 b43c9000 r-xp /usr/lib/libgpg-error.so.0.15.0
b43da000 b4410000 r-xp /usr/lib/libpulse.so.0.16.2
b4421000 b4464000 r-xp /usr/lib/libsndfile.so.1.0.25
b4479000 b448e000 r-xp /lib/libexpat.so.1.5.2
b44a0000 b455e000 r-xp /usr/lib/libcairo.so.2.11200.14
b4572000 b457a000 r-xp /usr/lib/libdrm.so.2.4.0
b458a000 b458d000 r-xp /usr/lib/libdri2.so.0.0.0
b459d000 b45eb000 r-xp /usr/lib/libssl.so.1.0.0
b4600000 b460c000 r-xp /usr/lib/libeeze.so.1.13.0
b461d000 b4626000 r-xp /usr/lib/libethumb.so.1.13.0
b4636000 b4639000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4649000 b4800000 r-xp /usr/lib/libcrypto.so.1.0.0
b55eb000 b55f4000 r-xp /usr/lib/libXi.so.6.1.0
b5604000 b5606000 r-xp /usr/lib/libXgesture.so.7.0.0
b5616000 b561a000 r-xp /usr/lib/libXtst.so.6.1.0
b562a000 b5630000 r-xp /usr/lib/libXrender.so.1.3.0
b5640000 b5646000 r-xp /usr/lib/libXrandr.so.2.2.0
b5656000 b5658000 r-xp /usr/lib/libXinerama.so.1.0.0
b5669000 b566c000 r-xp /usr/lib/libXfixes.so.3.1.0
b567c000 b5687000 r-xp /usr/lib/libXext.so.6.4.0
b5697000 b5699000 r-xp /usr/lib/libXdamage.so.1.1.0
b56a9000 b56ab000 r-xp /usr/lib/libXcomposite.so.1.0.0
b56bb000 b579d000 r-xp /usr/lib/libX11.so.6.3.0
b57b1000 b57b8000 r-xp /usr/lib/libXcursor.so.1.0.2
b57c8000 b57e0000 r-xp /usr/lib/libudev.so.1.6.0
b57e2000 b57e5000 r-xp /lib/libattr.so.1.1.0
b57f5000 b5815000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5816000 b581b000 r-xp /usr/lib/libffi.so.6.0.2
b582c000 b5844000 r-xp /lib/libz.so.1.2.8
b5854000 b5856000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5866000 b593b000 r-xp /usr/lib/libxml2.so.2.9.2
b5950000 b59eb000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a07000 b5a0a000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a1a000 b5a33000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a44000 b5a55000 r-xp /lib/libresolv-2.20-2014.11.so
b5a69000 b5ae3000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5af8000 b5afa000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b0a000 b5b11000 r-xp /usr/lib/libembryo.so.1.13.0
b5b21000 b5b2b000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5b3c000 b5b54000 r-xp /usr/lib/libpng12.so.0.50.0
b5b65000 b5b88000 r-xp /usr/lib/libjpeg.so.8.0.2
b5ba9000 b5bbd000 r-xp /usr/lib/libector.so.1.13.0
b5bce000 b5be6000 r-xp /usr/lib/liblua-5.1.so
b5bf7000 b5c4e000 r-xp /usr/lib/libfreetype.so.6.11.3
b5c62000 b5c8a000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5c9b000 b5cae000 r-xp /usr/lib/libfribidi.so.0.3.1
b5cbf000 b5cf9000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d0a000 b5d18000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d28000 b5d30000 r-xp /usr/lib/libtbm.so.1.0.0
b5d40000 b5d4d000 r-xp /usr/lib/libeio.so.1.13.0
b5d5d000 b5d5f000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5d6f000 b5d74000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5d84000 b5d9b000 r-xp /usr/lib/libefreet.so.1.13.0
b5dad000 b5dcd000 r-xp /usr/lib/libeldbus.so.1.13.0
b5ddd000 b5dfd000 r-xp /usr/lib/libecore_con.so.1.13.0
b5dff000 b5e05000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e15000 b5e26000 r-xp /usr/lib/libemotion.so.1.13.0
b5e37000 b5e3e000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e4e000 b5e5d000 r-xp /usr/lib/libeo.so.1.13.0
b5e6e000 b5e80000 r-xp /usr/lib/libecore_input.so.1.13.0
b5e91000 b5e96000 r-xp /usr/lib/libecore_file.so.1.13.0
b5ea6000 b5ebf000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5ecf000 b5eec000 r-xp /usr/lib/libeet.so.1.13.0
b5f05000 b5f4d000 r-xp /usr/lib/libeina.so.1.13.0
b5f5e000 b5f6e000 r-xp /usr/lib/libefl.so.1.13.0
b5f7f000 b6064000 r-xp /usr/lib/libicuuc.so.51.1
b6081000 b61c1000 r-xp /usr/lib/libicui18n.so.51.1
b61d8000 b6210000 r-xp /usr/lib/libecore_x.so.1.13.0
b6222000 b6225000 r-xp /lib/libcap.so.2.21
b6235000 b625e000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b626f000 b6276000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6288000 b62bf000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b62d0000 b63bb000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b63ce000 b6447000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6459000 b645e000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b646e000 b6478000 r-xp /usr/lib/libvconf.so.0.2.45
b6488000 b648a000 r-xp /usr/lib/libvasum.so.0.3.1
b649a000 b649c000 r-xp /usr/lib/libttrace.so.1.1
b64ac000 b64af000 r-xp /usr/lib/libiniparser.so.0
b64bf000 b64e5000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b64f5000 b64fa000 r-xp /usr/lib/libxdgmime.so.1.1.0
b650b000 b6522000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6533000 b659e000 r-xp /lib/libm-2.20-2014.11.so
b65af000 b65b5000 r-xp /lib/librt-2.20-2014.11.so
b65c6000 b65d3000 r-xp /usr/lib/libunwind.so.8.0.1
b6609000 b672d000 r-xp /lib/libc-2.20-2014.11.so
b6742000 b675b000 r-xp /lib/libgcc_s-4.9.so.1
b676b000 b684d000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b685e000 b6888000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6899000 b68d5000 r-xp /usr/lib/libsystemd.so.0.4.0
b68d7000 b695a000 r-xp /usr/lib/libedje.so.1.13.0
b696d000 b698b000 r-xp /usr/lib/libecore.so.1.13.0
b69ab000 b6b32000 r-xp /usr/lib/libevas.so.1.13.0
b6b67000 b6b7b000 r-xp /lib/libpthread-2.20-2014.11.so
b6b8f000 b6dc3000 r-xp /usr/lib/libelementary.so.1.13.0
b6df2000 b6df6000 r-xp /usr/lib/libsmack.so.1.0.0
b6e06000 b6e0d000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e1d000 b6e1f000 r-xp /usr/lib/libdlog.so.0.0.0
b6e2f000 b6e32000 r-xp /usr/lib/libbundle.so.0.1.22
b6e42000 b6e44000 r-xp /lib/libdl-2.20-2014.11.so
b6e55000 b6e6d000 r-xp /usr/lib/libaul.so.0.1.0
b6e81000 b6e86000 r-xp /usr/lib/libappcore-efl.so.1.1
b6e97000 b6ea4000 r-xp /usr/lib/liblptcp.so
b6eb6000 b6eba000 r-xp /usr/lib/libsys-assert.so
b6ecb000 b6eeb000 r-xp /lib/ld-2.20-2014.11.so
b6efc000 b6f01000 r-xp /usr/bin/launchpad-loader
b847f000 b86c4000 rw-p [heap]
be93d000 be95e000 rw-p [stack]
End of Maps Information

Callstack Information (PID:21635)
Call Stack Count: 1
 0: gsignal + 0x34 (0xb6634b84) [/lib/libc.so.6] + 0x2bb84
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
control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
06-13 14:25:57.306+0900 W/STARTER (  721): hw_key.c: _homekey_timer_cb(479) > [_homekey_timer_cb:479] _homekey_timer_cb, homekey count[1], lock state[0]
06-13 14:25:57.306+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
06-13 14:25:57.306+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
06-13 14:25:57.306+0900 E/STARTER (  721): )
06-13 14:25:57.306+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
06-13 14:25:57.306+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 1167
06-13 14:25:57.316+0900 W/AUL     (  721): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.homescreen)
06-13 14:25:57.316+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 0
06-13 14:25:57.326+0900 I/AUL     (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/starter, ret : 0
06-13 14:25:57.326+0900 E/AUL_AMD (  607): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
06-13 14:25:57.326+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 721
06-13 14:25:57.326+0900 E/AUL_AMD (  607): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-13 14:25:57.336+0900 W/AUL     (  607): app_signal.c: aul_send_app_resume_request_signal(468) > send_app_resume_signal, pid: 1167, appid: com.samsung.homescreen
06-13 14:25:57.346+0900 W/AUL_AMD (  607): amd_launch.c: __nofork_processing(1412) > __nofork_processing, cmd: 0, pid: 1167
06-13 14:25:57.346+0900 W/AUL_AMD (  607): amd_request.c: __send_home_launch_signal(577) > send a home launch signal
06-13 14:25:57.346+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(514) > [APP 1167] Event: RESET State: PAUSED
06-13 14:25:57.346+0900 I/CAPI_APPFW_APPLICATION( 1167): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-13 14:25:57.346+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Home]Key [Down]Event!! 
06-13 14:25:57.346+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Home]Key [Up]Event!! 
06-13 14:25:57.356+0900 W/AUL_AMD (  607): amd_launch.c: __reply_handler(1083) > listen fd(32) , send fd(31), pid(1167), cmd(0)
06-13 14:25:57.356+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollStarted(4737) >  Main Scroll Started
06-13 14:25:57.356+0900 W/AUL     (  721): launch.c: app_request_to_launchpad(425) > request cmd(0) result(1167)
06-13 14:25:57.356+0900 E/STARTER (  721): dbus-util.c: starter_dbus_home_raise_signal_send(219) > [starter_dbus_home_raise_signal_send:219] Sending HOME RAISE signal, result:0
06-13 14:25:57.366+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollCompleted(4747) >  Main Scroll Completed
06-13 14:25:57.366+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollCompleted(4750) >  Main Scroll Completed Done
06-13 14:25:57.366+0900 W/CAPI_APPFW_APP_CONTROL( 1167): app_control.c: app_control_error(152) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-13 14:25:57.376+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(564) > Legacy lifecycle: 0
06-13 14:25:57.376+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(566) > [APP 1167] App already running, raise the window
06-13 14:25:57.386+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(3)
06-13 14:25:57.386+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 14:25:57.386+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-13 14:25:57.386+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(1167)
06-13 14:25:57.386+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1167, appid: com.samsung.homescreen, status: fg
06-13 14:25:57.446+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:25:57.446+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:25:57.456+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(514) > [APP 1167] Event: RESUME State: PAUSED
06-13 14:25:57.456+0900 I/CAPI_APPFW_APPLICATION( 1167): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-13 14:25:57.456+0900 E/cluster-home( 1167): homescreen.cpp: OnResume(233) >  app resume
06-13 14:25:57.456+0900 I/APP_CORE(21476): appcore-efl.c: __do_app(514) > [APP 21476] Event: PAUSE State: RUNNING
06-13 14:25:57.456+0900 I/CAPI_APPFW_APPLICATION(21476): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-13 14:25:57.466+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(21476) status(4)
06-13 14:25:57.466+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.myfile-lite(21476)
06-13 14:25:57.466+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 21476, appid: com.samsung.myfile-lite, status: bg
06-13 14:25:57.476+0900 E/weather-widget( 1324): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-13 14:25:57.476+0900 I/Tizen::System( 1175): (259) > Active app [com.samsun], current [com.samsun] 
06-13 14:25:57.476+0900 I/Tizen::System( 1175): (273) > Current App[com.samsun] is already actived.
06-13 14:25:57.486+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-13 14:25:57.486+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-13 14:25:57.486+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:25:57.486+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:25:57.486+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:25:57.506+0900 E/weather-widget( 1324): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-13 14:25:57.516+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:25:57.516+0900 E/weather-widget( 1324): WidgetMain.cpp: ResumeWidgetInstance(585) > [0;40;31m[ResumeWidgetInstance(): 585] (widgetViewDataPtr->GetNumberOfCities() <= 0) [break][0;m
06-13 14:25:57.516+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-13 14:25:57.516+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-13 14:25:57.516+0900 W/AUL     ( 1324): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1324, appid: com.samsung.weather-m-widget, status: fg
06-13 14:25:57.516+0900 I/TIZEN_N_SOUND_MANAGER(  910): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=8, ret=0x0
06-13 14:25:57.516+0900 E/TIZEN_N_SOUND_MANAGER(  910): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-13 14:25:57.526+0900 I/TIZEN_N_EFL_UTIL_WINDOW(21476): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 64
06-13 14:25:57.526+0900 E/APP_CORE(21476): appcore-efl.c: _capture_and_make_file(1619) > win[3200003] widget[720] height[1280]
06-13 14:25:57.526+0900 I/TIZEN_N_SOUND_MANAGER(  910): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=7, ret=0x0
06-13 14:25:57.526+0900 E/TIZEN_N_SOUND_MANAGER(  910): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-13 14:25:57.526+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:25:57.556+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 33
06-13 14:25:57.626+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-13 14:25:57.626+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:25:58.687+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=18544897
06-13 14:25:58.687+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Home]Key [Down]Event!! 
06-13 14:25:58.697+0900 E/EFL     (  857): ecore_x<857> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=18544897
06-13 14:25:58.697+0900 W/STARTER (  721): hw_key.c: _key_press_cb(758) > [_key_press_cb:758] Home Key is pressed
06-13 14:25:58.697+0900 W/STARTER (  721): hw_key.c: _key_press_cb(776) > [_key_press_cb:776] homekey count : 1
06-13 14:25:58.988+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
06-13 14:25:58.988+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
06-13 14:25:58.988+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
06-13 14:25:58.988+0900 E/STARTER (  721): )
06-13 14:25:58.998+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
06-13 14:25:58.998+0900 E/VOLUME  (  859): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
06-13 14:25:58.998+0900 E/VOLUME  (  859): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
06-13 14:25:59.018+0900 W/AUL     (  721): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.task-mgr)
06-13 14:25:59.018+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 0
06-13 14:25:59.018+0900 I/AUL     (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/starter, ret : 0
06-13 14:25:59.018+0900 E/AUL_AMD (  607): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
06-13 14:25:59.018+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 721
06-13 14:25:59.018+0900 E/AUL_AMD (  607): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-13 14:25:59.038+0900 E/RESOURCED(  667): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 14:25:59.058+0900 I/GXT_SIB (  342): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
06-13 14:25:59.058+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:783 _eo_api_op_id_get() in elm_layout.eo.c:34: unable to resolve regular api func 'elm_obj_layout_edje_get' 0xb6bdc6e9 in class 'Edje_Object'.
06-13 14:25:59.058+0900 E/UXT     (  342): uxt_theme_object.c: uxt_theme_object_set_changeable_ui_enabled(42) > failed to get edje from parent object.
06-13 14:25:59.068+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
06-13 14:25:59.068+0900 W/AUL_PAD ( 1377): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-13 14:25:59.068+0900 W/AUL_PAD ( 1377): launchpad.c: __send_result_to_caller(267) > Check app launching
06-13 14:25:59.088+0900 E/CAPI_APPFW_APPLICATION(21609): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 14:25:59.088+0900 E/CAPI_APPFW_APPLICATION(21609): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 14:25:59.088+0900 E/CAPI_APPFW_APPLICATION(21609): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 14:25:59.088+0900 E/CAPI_APPFW_APPLICATION(21609): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 14:25:59.088+0900 E/CAPI_APPFW_APPLICATION(21609): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 14:25:59.088+0900 I/CAPI_APPFW_APPLICATION(21609): app_main.c: ui_app_main(789) > app_efl_main
06-13 14:25:59.088+0900 I/CAPI_APPFW_APPLICATION(21609): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-13 14:25:59.168+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 21609, appid: com.samsung.task-mgr
06-13 14:25:59.168+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-13 14:25:59.168+0900 W/TASK_MGR_LITE(21609): task-mgr-lite.c: create_win(197) > changeable ui enabled success
06-13 14:25:59.168+0900 E/RESOURCED(  667): proc-main.c: proc_add_program_list(237) > not found ppi : com.samsung.task-mgr
06-13 14:25:59.168+0900 W/AUL     (  721): launch.c: app_request_to_launchpad(425) > request cmd(0) result(21609)
06-13 14:25:59.188+0900 I/GXT_SIB (21609): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
06-13 14:25:59.218+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:25:59.218+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:25:59.248+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:25:59.248+0900 I/Tizen::System( 1175): (259) > Active app [com.samsun], current [com.samsun] 
06-13 14:25:59.248+0900 I/Tizen::System( 1175): (273) > Current App[com.samsun] is already actived.
06-13 14:25:59.258+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:25:59.258+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:25:59.278+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:25:59.278+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:25:59.288+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 12
06-13 14:25:59.288+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:25:59.298+0900 E/RUA     (21609): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 26, ncols : 5
06-13 14:25:59.298+0900 E/TASK_MGR_LITE(21609): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.homescreen) in ai_tbl !!
06-13 14:25:59.298+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
06-13 14:25:59.298+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
06-13 14:25:59.298+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
06-13 14:25:59.308+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 21476
06-13 14:25:59.308+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 12
06-13 14:25:59.308+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:25:59.308+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
06-13 14:25:59.308+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 21459
06-13 14:25:59.308+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 12
06-13 14:25:59.308+0900 E/TASK_MGR_LITE(21609): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.task-mgr) in ai_tbl !!
06-13 14:25:59.308+0900 E/TASK_MGR_LITE(21609): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-agent) in ai_tbl !!
06-13 14:25:59.308+0900 E/TASK_MGR_LITE(21609): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.poweroff-syspopup) in ai_tbl !!
06-13 14:25:59.308+0900 E/TASK_MGR_LITE(21609): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.tizenstoreservice) in ai_tbl !!
06-13 14:25:59.308+0900 E/TASK_MGR_LITE(21609): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.image-viewer-subapp-single) in ai_tbl !!
06-13 14:25:59.308+0900 E/TASK_MGR_LITE(21609): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.sdbd-syspopup) in ai_tbl !!
06-13 14:25:59.308+0900 E/TASK_MGR_LITE(21609): recent_apps.c: list_retrieve_item(263) > Can't find app (net.netpopup) in ai_tbl !!
06-13 14:25:59.308+0900 E/TASK_MGR_LITE(21609): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.crash-viewer) in ai_tbl !!
06-13 14:25:59.308+0900 E/TASK_MGR_LITE(21609): recent_apps.c: list_retrieve_item(263) > Can't find app (wifi-efl-ug-lite) in ai_tbl !!
06-13 14:25:59.308+0900 E/TASK_MGR_LITE(21609): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.special-day-app) in ai_tbl !!
06-13 14:25:59.308+0900 E/TASK_MGR_LITE(21609): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.wallpaper-ui-service) in ai_tbl !!
06-13 14:25:59.308+0900 E/TASK_MGR_LITE(21609): recent_apps.c: list_retrieve_item(263) > Can't find app (net.wifi-qs) in ai_tbl !!
06-13 14:25:59.308+0900 E/TASK_MGR_LITE(21609): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.smart-switch-noti) in ai_tbl !!
06-13 14:25:59.308+0900 E/TASK_MGR_LITE(21609): recent_apps.c: list_retrieve_item(263) > Can't find app (live-com.samsung.browser) in ai_tbl !!
06-13 14:25:59.308+0900 E/TASK_MGR_LITE(21609): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-widget) in ai_tbl !!
06-13 14:25:59.308+0900 E/TASK_MGR_LITE(21609): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.quickpanel) in ai_tbl !!
06-13 14:25:59.308+0900 E/TASK_MGR_LITE(21609): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.setup-wizard) in ai_tbl !!
06-13 14:25:59.308+0900 E/TASK_MGR_LITE(21609): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.pwlock) in ai_tbl !!
06-13 14:25:59.308+0900 E/TASK_MGR_LITE(21609): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.volume) in ai_tbl !!
06-13 14:25:59.308+0900 E/TASK_MGR_LITE(21609): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.lockscreen) in ai_tbl !!
06-13 14:25:59.308+0900 E/TASK_MGR_LITE(21609): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.clock-alarm-service) in ai_tbl !!
06-13 14:25:59.318+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:25:59.338+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:25:59.358+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:25:59.368+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:25:59.378+0900 I/APP_CORE(21609): appcore-efl.c: __do_app(514) > [APP 21609] Event: RESET State: CREATED
06-13 14:25:59.378+0900 I/CAPI_APPFW_APPLICATION(21609): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-13 14:25:59.388+0900 E/EFL     (21609): edje<21609> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:25:59.388+0900 E/EFL     (21609): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:25:59.388+0900 E/EFL     (21609): edje<21609> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:25:59.388+0900 E/EFL     (21609): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:25:59.388+0900 W/APP_CORE(21609): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5800003
06-13 14:25:59.388+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 35
06-13 14:25:59.388+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:25:59.408+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:25:59.558+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(21609) status(0)
06-13 14:25:59.568+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(21609) status(0)
06-13 14:25:59.568+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(514) > [APP 1167] Event: PAUSE State: RUNNING
06-13 14:25:59.568+0900 I/CAPI_APPFW_APPLICATION( 1167): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-13 14:25:59.568+0900 E/cluster-home( 1167): homescreen.cpp: OnPause(260) >  app pause
06-13 14:25:59.568+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(4)
06-13 14:25:59.568+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(1167)
06-13 14:25:59.568+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1167, appid: com.samsung.homescreen, status: bg
06-13 14:25:59.578+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(21609) status(3)
06-13 14:25:59.578+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 14:25:59.578+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-13 14:25:59.578+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.task-mgr(21609)
06-13 14:25:59.578+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 21609, appid: com.samsung.task-mgr, status: fg
06-13 14:25:59.578+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:25:59.578+0900 E/EFL     (  857): ecore_x<857> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=18545798
06-13 14:25:59.578+0900 W/STARTER (  721): hw_key.c: _key_release_cb(578) > [_key_release_cb:578] Home Key is released
06-13 14:25:59.578+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=18545798
06-13 14:25:59.578+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Home]Key [Up]Event!! 
06-13 14:25:59.588+0900 E/weather-widget( 1324): Widget4x4Page.cpp: SetRefreshButton(72) > [0;40;31m[SetRefreshButton(): 72] (mCityLayout == NULL) [return][0;m
06-13 14:25:59.588+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
06-13 14:25:59.588+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
06-13 14:25:59.588+0900 E/STARTER (  721): )
06-13 14:25:59.588+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-13 14:25:59.588+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-13 14:25:59.588+0900 W/AUL     ( 1324): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1324, appid: com.samsung.weather-m-widget, status: bg
06-13 14:25:59.588+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
06-13 14:25:59.588+0900 I/APP_CORE(21609): appcore-efl.c: __do_app(514) > [APP 21609] Event: RESUME State: CREATED
06-13 14:25:59.598+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
06-13 14:25:59.598+0900 E/VOLUME  (  859): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
06-13 14:25:59.598+0900 E/VOLUME  (  859): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
06-13 14:25:59.598+0900 I/APP_CORE(21609): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-13 14:25:59.598+0900 I/APP_CORE(21609): appcore-efl.c: __do_app(625) > [APP 21609] Initial Launching, call the resume_cb
06-13 14:25:59.598+0900 I/CAPI_APPFW_APPLICATION(21609): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-13 14:26:00.079+0900 E/EFL     (21609): ecore_x<21609> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18546290
06-13 14:26:00.179+0900 E/EFL     (21609): ecore_x<21609> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=18546390
06-13 14:26:00.259+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2111
06-13 14:26:00.279+0900 I/Tizen::App( 1175): (499) > LaunchedApp(com.samsung.task-mgr)
06-13 14:26:00.279+0900 I/Tizen::App( 1175): (733) > Finished invoking application event listener for com.samsung.task-mgr, 21609.
06-13 14:26:00.499+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 22
06-13 14:26:00.499+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(1201) > app status : 5
06-13 14:26:00.499+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.task-mgr(21609)
06-13 14:26:00.499+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 21609, appid: com.samsung.task-mgr, status: bg
06-13 14:26:00.499+0900 I/CAPI_APPFW_APPLICATION(21609): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-13 14:26:00.499+0900 W/TASK_MGR_LITE(21609): task-mgr-lite.c: _pause_app(406) > 
06-13 14:26:00.499+0900 I/CAPI_APPFW_APPLICATION(21609): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
06-13 14:26:00.499+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
06-13 14:26:00.499+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 21476
06-13 14:26:00.499+0900 W/AUL     (21609): launch.c: app_request_to_launchpad(396) > request cmd(4) to(21476)
06-13 14:26:00.499+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 4
06-13 14:26:00.509+0900 I/APP_CORE(21476): appcore-efl.c: __do_app(514) > [APP 21476] Event: TERMINATE State: PAUSED
06-13 14:26:00.509+0900 W/AUL_AMD (  607): amd_launch.c: __reply_handler(1083) > listen fd(32) , send fd(31), pid(21476), cmd(4)
06-13 14:26:00.509+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 22
06-13 14:26:00.509+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(1201) > app status : 5
06-13 14:26:00.509+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 22
06-13 14:26:00.509+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(1201) > app status : 5
06-13 14:26:00.509+0900 W/AUL     (21609): launch.c: app_request_to_launchpad(425) > request cmd(4) result(0)
06-13 14:26:00.519+0900 I/TIZEN_N_EFL_UTIL_WINDOW(21476): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 13
06-13 14:26:00.519+0900 E/APP_CORE(21476): appcore-efl.c: _capture_and_make_file(1619) > win[3200003] widget[720] height[1280]
06-13 14:26:00.519+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 33
06-13 14:26:00.519+0900 E/APP_CORE(21476): appcore-efl.c: _capture_and_make_file(1622) > cannot a capture file for the package of [com.samsung.myfile-lite]
06-13 14:26:00.529+0900 I/CAPI_APPFW_APPLICATION(21476): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
06-13 14:26:00.529+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
06-13 14:26:00.529+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 21459
06-13 14:26:00.529+0900 W/AUL     (21609): launch.c: app_request_to_launchpad(396) > request cmd(4) to(21459)
06-13 14:26:00.529+0900 I/CAPI_CONTENT_MEDIA_CONTENT(21476): media_content.c: media_content_disconnect(940) > [32m[21476]ref count changed to: 0
06-13 14:26:00.529+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 4
06-13 14:26:00.529+0900 W/AUL_AMD (  607): amd_launch.c: __reply_handler(1083) > listen fd(32) , send fd(31), pid(21459), cmd(4)
06-13 14:26:00.529+0900 W/AUL     (21609): launch.c: app_request_to_launchpad(425) > request cmd(4) result(0)
06-13 14:26:00.529+0900 I/APP_CORE(21459): appcore-efl.c: __do_app(514) > [APP 21459] Event: TERMINATE State: PAUSED
06-13 14:26:00.529+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 22
06-13 14:26:00.529+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(1201) > app status : 5
06-13 14:26:00.539+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 22
06-13 14:26:00.539+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(1201) > app status : 5
06-13 14:26:00.539+0900 E/CLOUD_CONTENT_SYNC_CLIENT(21476): cs_client.c: cloud_content_sync_folder_unset_changed_cb(3749) > [0;31m* Critical * Invalid handle[0;m
06-13 14:26:00.539+0900 E/CLOUD_CONTENT_SYNC_CLIENT(21476): cs_client.c: cloud_content_sync_content_unset_changed_cb(3662) > [0;31m* Critical * Invalid handle[0;m
06-13 14:26:00.539+0900 W/MYFILES (21476): mf-cloud-service.c: mf_cloud_content_destroy_handle(61) > handle is NULL
06-13 14:26:00.539+0900 E/MYFILES (21476): mf-cloud-operation.c: mf_cloud_operation_src_list_free(147) > [31mmore is [0][0m
06-13 14:26:00.539+0900 E/EFL     (21476): <21476> e_dbus.c:640 e_dbus_shutdown() Init count not greater than 0 in shutdown.
06-13 14:26:00.539+0900 E/TASK_MGR_LITE(21609): recent_app_viewer.c: destroy_recent_app_viewer(1583) > destroy_recent_app_viewer
06-13 14:26:00.549+0900 I/TIZEN_N_EFL_UTIL_WINDOW(21459): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 12
06-13 14:26:00.549+0900 E/APP_CORE(21459): appcore-efl.c: _capture_and_make_file(1619) > win[8200002] widget[720] height[1280]
06-13 14:26:00.549+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 33
06-13 14:26:00.549+0900 E/APP_CORE(21459): appcore-efl.c: _capture_and_make_file(1622) > cannot a capture file for the package of [org.example.client]
06-13 14:26:00.559+0900 I/CAPI_APPFW_APPLICATION(21459): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
06-13 14:26:00.579+0900 E/APP_CORE(21609): appcore.c: appcore_flush_memory(793) > Appcore not initialized
06-13 14:26:00.589+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:26:00.589+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(3)
06-13 14:26:00.589+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 14:26:00.589+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-13 14:26:00.589+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(1167)
06-13 14:26:00.589+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1167, appid: com.samsung.homescreen, status: fg
06-13 14:26:00.629+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(0)
06-13 14:26:00.639+0900 I/MALI    (21609): egl_platform_x11.c: __egl_platform_terminate(358) > [EGL-X11] PID=21609   close drm_fd=30 
06-13 14:26:00.669+0900 I/INDICATOR(  665): clock.c: indicator_clock_changed_cb(195) > ""
06-13 14:26:00.679+0900 E/UXT     (  665): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오후 2:26
06-13 14:26:00.679+0900 I/INDICATOR(  665): clock.c: getTimeFormatted(176) > "time format : 오후 2:26"
06-13 14:26:00.679+0900 I/INDICATOR(  665): clock.c: indicator_clock_changed_cb(244) > "time format : 오후 2:26"
06-13 14:26:00.679+0900 W/INDICATOR(  665): clock.c: indicator_clock_changed_cb(272) > 
06-13 14:26:00.679+0900 I/INDICATOR(  665): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146567765 Time: <font_size=31> </font_size> <font_size=31> 오후 2:26</font_size></font>"
06-13 14:26:00.689+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(514) > [APP 1167] Event: RESUME State: PAUSED
06-13 14:26:00.689+0900 I/CAPI_APPFW_APPLICATION( 1167): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-13 14:26:00.689+0900 E/cluster-home( 1167): homescreen.cpp: OnResume(233) >  app resume
06-13 14:26:00.689+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:26:00.719+0900 E/weather-widget( 1324): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-13 14:26:00.739+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:26:00.749+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-13 14:26:00.749+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-13 14:26:00.749+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:26:00.749+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:26:00.749+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:26:00.749+0900 I/Tizen::System( 1175): (259) > Active app [com.samsun], current [com.samsun] 
06-13 14:26:00.749+0900 I/Tizen::System( 1175): (273) > Current App[com.samsun] is already actived.
06-13 14:26:00.769+0900 E/weather-widget( 1324): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-13 14:26:00.789+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:26:00.789+0900 E/weather-widget( 1324): WidgetMain.cpp: ResumeWidgetInstance(585) > [0;40;31m[ResumeWidgetInstance(): 585] (widgetViewDataPtr->GetNumberOfCities() <= 0) [break][0;m
06-13 14:26:00.789+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-13 14:26:00.789+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-13 14:26:00.789+0900 W/AUL     ( 1324): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1324, appid: com.samsung.weather-m-widget, status: fg
06-13 14:26:00.880+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-13 14:26:00.890+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:26:00.910+0900 I/MALI    (21476): egl_platform_x11.c: __egl_platform_terminate(358) > [EGL-X11] PID=21476   close drm_fd=30 
06-13 14:26:01.020+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 21459 pgid = 21459
06-13 14:26:01.020+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(143) > dead_pid(21459)
06-13 14:26:01.050+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-13 14:26:01.050+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-13 14:26:01.050+0900 E/AUL_PAD ( 1377): launchpad.c: main(698) > error reading sigchld info
06-13 14:26:01.050+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 21459
06-13 14:26:01.050+0900 I/Tizen::App( 1175): (243) > App[org.example.client] pid[21459] terminate event is forwarded
06-13 14:26:01.050+0900 I/Tizen::System( 1175): (256) > osp.accessorymanager.service provider is found.
06-13 14:26:01.050+0900 I/Tizen::System( 1175): (196) > Accessory Owner is removed [org.example.client, 21459, ]
06-13 14:26:01.050+0900 I/Tizen::System( 1175): (256) > osp.system.service provider is found.
06-13 14:26:01.050+0900 I/Tizen::App( 1175): (506) > TerminatedApp(org.example.client)
06-13 14:26:01.050+0900 I/Tizen::App( 1175): (512) > Not registered pid(21459)
06-13 14:26:01.050+0900 I/Tizen::System( 1175): (246) > Terminated app [org.example.client]
06-13 14:26:01.050+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 21459
06-13 14:26:01.060+0900 I/Tizen::Io( 1175): (729) > Entry not found
06-13 14:26:01.060+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2112
06-13 14:26:01.070+0900 I/Tizen::System( 1175): (157) > change brightness system value.
06-13 14:26:01.070+0900 I/Tizen::App( 1175): (782) > Finished invoking application event listener for org.example.client, 21459.
06-13 14:26:01.140+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2113
06-13 14:26:01.160+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 21609 pgid = 21609
06-13 14:26:01.160+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(143) > dead_pid(21609)
06-13 14:26:01.200+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-13 14:26:01.200+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-13 14:26:01.200+0900 E/AUL_PAD ( 1377): launchpad.c: main(698) > error reading sigchld info
06-13 14:26:01.210+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 21609
06-13 14:26:01.210+0900 I/Tizen::App( 1175): (243) > App[com.samsung.task-mgr] pid[21609] terminate event is forwarded
06-13 14:26:01.210+0900 I/Tizen::System( 1175): (256) > osp.accessorymanager.service provider is found.
06-13 14:26:01.210+0900 I/Tizen::System( 1175): (196) > Accessory Owner is removed [com.samsung.task-mgr, 21609, ]
06-13 14:26:01.210+0900 I/Tizen::System( 1175): (256) > osp.system.service provider is found.
06-13 14:26:01.210+0900 I/Tizen::App( 1175): (506) > TerminatedApp(com.samsung.task-mgr)
06-13 14:26:01.210+0900 I/Tizen::App( 1175): (512) > Not registered pid(21609)
06-13 14:26:01.210+0900 I/Tizen::System( 1175): (246) > Terminated app [com.samsung.task-mgr]
06-13 14:26:01.210+0900 I/Tizen::Io( 1175): (729) > Entry not found
06-13 14:26:01.210+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 21609
06-13 14:26:01.210+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 21609
06-13 14:26:01.220+0900 I/Tizen::System( 1175): (157) > change brightness system value.
06-13 14:26:01.220+0900 I/Tizen::App( 1175): (782) > Finished invoking application event listener for com.samsung.task-mgr, 21609.
06-13 14:26:01.280+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 21476 pgid = 21476
06-13 14:26:01.280+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(143) > dead_pid(21476)
06-13 14:26:01.310+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-13 14:26:01.310+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-13 14:26:01.310+0900 E/AUL_PAD ( 1377): launchpad.c: main(698) > error reading sigchld info
06-13 14:26:01.310+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 21476
06-13 14:26:01.310+0900 I/Tizen::App( 1175): (243) > App[com.samsung.myfile-lite] pid[21476] terminate event is forwarded
06-13 14:26:01.310+0900 I/Tizen::System( 1175): (256) > osp.accessorymanager.service provider is found.
06-13 14:26:01.310+0900 I/Tizen::System( 1175): (196) > Accessory Owner is removed [com.samsung.myfile-lite, 21476, ]
06-13 14:26:01.310+0900 I/Tizen::System( 1175): (256) > osp.system.service provider is found.
06-13 14:26:01.310+0900 I/Tizen::App( 1175): (506) > TerminatedApp(com.samsung.myfile-lite)
06-13 14:26:01.310+0900 I/Tizen::App( 1175): (512) > Not registered pid(21476)
06-13 14:26:01.310+0900 I/Tizen::System( 1175): (246) > Terminated app [com.samsung.myfile-lite]
06-13 14:26:01.310+0900 I/Tizen::Io( 1175): (729) > Entry not found
06-13 14:26:01.310+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 21476
06-13 14:26:01.320+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2116
06-13 14:26:01.330+0900 I/Tizen::System( 1175): (157) > change brightness system value.
06-13 14:26:01.330+0900 I/Tizen::App( 1175): (782) > Finished invoking application event listener for com.samsung.myfile-lite, 21476.
06-13 14:26:01.550+0900 I/UXT     (21652): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-13 14:26:01.600+0900 E/TBM     (21652): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-13 14:26:01.600+0900 I/MALI    (21652): egl_platform_x11.c: __egl_platform_initialize(242) > [EGL-X11] PID=21652   open drm_fd=30 
06-13 14:26:01.730+0900 E/EFL     (21652): edje<21652> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:26:01.730+0900 E/EFL     (21652): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:26:01.730+0900 E/EFL     (21652): edje<21652> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:26:01.730+0900 E/EFL     (21652): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:26:01.730+0900 E/EFL     (21652): edje<21652> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:26:01.730+0900 E/EFL     (21652): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:26:05.504+0900 W/AUL_AMD (  607): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
06-13 14:26:05.514+0900 W/AUL_AMD (  607): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
06-13 14:26:05.514+0900 W/AUL_AMD (  607): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
06-13 14:26:05.534+0900 W/AUL_AMD (  607): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
06-13 14:26:05.544+0900 W/AUL_AMD (  607): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
06-13 14:26:07.186+0900 E/PKGMGR_SERVER(21699): pkgmgr-server.c: main(2414) > package manager server start
06-13 14:26:07.246+0900 E/PKGMGR  (21697): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.client, -1]
06-13 14:26:07.276+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
06-13 14:26:07.286+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
06-13 14:26:07.296+0900 E/PKGMGR_SERVER(21699): pkgmgr-server.c: sighandler(417) > child NORMAL exit [21702]
06-13 14:26:07.726+0900 E/AUL_AMD (  607): amd_launch.c: _amd_proc_find_proc_info(1914) > proc info not found
06-13 14:26:09.728+0900 W/AUL     (21751): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
06-13 14:26:09.728+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 0
06-13 14:26:09.738+0900 I/AUL     (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
06-13 14:26:09.748+0900 I/AUL     (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
06-13 14:26:09.748+0900 E/AUL_AMD (  607): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
06-13 14:26:09.748+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 21751
06-13 14:26:09.748+0900 E/AUL_AMD (  607): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-13 14:26:09.758+0900 E/RESOURCED(  667): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 7
06-13 14:26:09.758+0900 E/RESOURCED(  667): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 14:26:09.758+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
06-13 14:26:09.758+0900 W/AUL_PAD ( 1377): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-13 14:26:09.758+0900 W/AUL_PAD ( 1377): launchpad.c: __send_result_to_caller(267) > Check app launching
06-13 14:26:09.768+0900 I/abc     (21635): abc
06-13 14:26:09.778+0900 I/CAPI_APPFW_APPLICATION(21635): app_main.c: ui_app_main(789) > app_efl_main
06-13 14:26:09.778+0900 I/CAPI_APPFW_APPLICATION(21635): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-13 14:26:09.788+0900 E/PKGMGR_SERVER(21699): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-13 14:26:09.788+0900 E/PKGMGR_SERVER(21699): pkgmgr-server.c: main(2471) > package manager server terminated.
06-13 14:26:09.818+0900 E/TBM     (21635): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-13 14:26:09.858+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 21635, appid: org.example.client
06-13 14:26:09.858+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-13 14:26:09.858+0900 W/AUL     (21751): launch.c: app_request_to_launchpad(425) > request cmd(0) result(21635)
06-13 14:26:10.058+0900 W/CRASH_MANAGER(21765): worker.c: worker_job(1199) > 0621635636c69149733156
